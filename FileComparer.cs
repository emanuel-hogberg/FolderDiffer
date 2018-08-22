using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPlex;
using DiffPlex.DiffBuilder;

namespace FolderDiffer
{
    public partial class FileComparer : Form
    {
        public FileComparer()
        {
            InitializeComponent();
            ResetComparison();
            rdoFilterOff.Checked = true;
            ignoreFileTypes.AddRange(new string[]
            {
                ".csproj",
                ".xaml",
                "\\bin",
                ".dll",
                ".pdb",
                ".exe",
                "\\debug",
                "\\release",
                ".appxmanifest"
            });
            listBox2.DataSource = ignoreFileTypes;
            this.btnCompareFolders.Select();
            this.txtFolder1.Text = @"C:\git\project1";
            this.txtFolder2.Text = @"C:\git\project2";
            var d = new Differ();
        }

        private List<FileComparison> files = new List<FileComparison>();
        private List<string> ignoreFileTypes = new List<string>();
        private bool contentDiffFilter = false;
        InlineDiffBuilder diffBuilder = new InlineDiffBuilder(new Differ());

        private IEnumerable<string> GetIgnoreFolders()
        {
            return ignoreFileTypes.Where(t => t.StartsWith("\\")).Select(t => t.Substring(1).ToLower());
        }

        private void btnCompareFolders_Click(object sender, EventArgs e)
        {
            try
            {
                ResetComparison();
            }
            catch (Exception ex)
            {
                this.txtFile1Contents.Text = ex.ToString();
                return;
            }

            if (txtFolder1.Text == txtFolder2.Text)
            {
                this.txtFile1Contents.Text = "It's the same folder.";
                return;
            }
            var comparisons = OpenFolder(txtFolder1.Text, txtFolder2.Text);
            this.files = comparisons.ToList();
            this.listBox1.DataSource = comparisons.ToList();
            FilterFiles();
        }

        private List<FileComparison> OpenFolder(string folder1, string folder2)
        {
            var comparisons = OpenFiles(folder1, folder2);

            if (!Directory.Exists(folder1) || !Directory.Exists(folder2))
            {
                txtFile1Contents.Text = Directory.Exists(folder1) ? folder1 + " exists" : folder1 + " does not exist!";
                txtFile2Contents.Text = Directory.Exists(folder2) ? folder2 + " exists" : folder2 + " does not exist!";
                return new List<FileComparison>();
            }
            
            // open all folderse, recursively get comparisons
            var folders1 = Directory.GetDirectories(folder1);
            var folders2 = Directory.GetDirectories(folder2);

            var missingFolders = folders1
                .Where(f => !folders2.Select(p => Path.GetFileName(p)).Contains(Path.GetFileName(f)))
                .Union(
                folders2
                .Where(f => !folders1.Select(p => Path.GetFileName(p)).Contains(Path.GetFileName(f)))
                );

            foreach(string folder in folders1.Where(f => !missingFolders.Contains(f) && !GetIgnoreFolders().Contains(Path.GetFileName(f).ToLower())))
            {
                comparisons.AddRange(
                    OpenFolder(folder,
                    folders2.Where(f =>
                        Path.GetFileName(f) == Path.GetFileName(folder))
                    .First())
                    );
            }

            return comparisons
                    .Union(
                        missingFolders.Select(f =>
                            new FileComparison()
                            {
                                Filename = f,
                                Path1 = f,
                                MissingFolder = true
                            }
                    ))
                    .ToList(); ;
        }

        private List<FileComparison> OpenFiles(string folder1, string folder2)
        {
            string[] files1 = new string[] { };
            string[] files2 = new string[] { };
            try
            {
                files1 = Directory.GetFiles(folder1);
                files2 = Directory.GetFiles(folder2);
            }
            catch (Exception ex)
            {
                this.txtFile1Contents.Text = ex.ToString();
            }

            try
            {
                var missingFiles = files1
                    .Where(
                        f => !files2.Select(p => 
                        Path.GetFileName(p)).Contains(Path.GetFileName(f)))
                    .Union(
                    files2
                    .Where(
                        f => !files1.Select(p => 
                        Path.GetFileName(p)).Contains(Path.GetFileName(f)))
                    );

                var f1 = files1.Select(file1 =>
                    new
                    {
                        FileName = Path.GetFileName(file1),
                        Path = file1,
                        Info = new FileInfo(file1)
                    });
                var f2 = files2.Select(file2 =>
                    new
                    {
                        FileName = Path.GetFileName(file2),
                        Path = file2,
                        Info = new FileInfo(file2)
                    });
                var comparisons = f1.Join(f2,
                    file1 => file1.FileName,
                    file2 => file2.FileName,
                    (file1, file2) =>
                        new FileComparison()
                        {
                            Filename = file1.FileName,
                            Path1 = file1.Path,
                            Path2 = file2.Path,
                            File = true,
                            File1Created = file1.Info.CreationTime,
                            File1Modified = file1.Info.LastWriteTime,
                            File2Created = file2.Info.CreationTime,
                            File2Modified = file2.Info.LastWriteTime
                        })
                     .Where(c => c.Diff);
                return comparisons
                    .Union(
                        missingFiles.Select(f =>
                            new FileComparison()
                            {
                                Filename = f,
                                Path1 = f,
                                MissingFile = true
                            }
                    ))
                    .ToList();
                //comparisons
                //.Select(c => c.Filename)
                //.ToArray());
            }
            catch (Exception ex)
            {
                this.txtFile1Contents.Text = ex.ToString();
            }
            return new List<FileComparison>();
        }

        class FileComparison
        {
            public string Filename { get; set; }
            public string Path1 { get; set; }
            public string Path2 { get; set; }
            public DateTime File1Modified { get; set; }
            public DateTime File1Created { get; set; }
            public DateTime File2Modified { get; set; }
            public DateTime File2Created { get; set; }
            public bool File { get; set; }
            public bool MissingFolder { get; set; }
            public bool MissingFile { get; set; }
            public ContentDiff ContentDiff { get; set; }
            public bool Diff
            {
                get
                {
                    if (File)
                        return File1Modified != File2Modified || File1Created != File2Created;
                    return true;
                }
            }
            public override string ToString()
            {
                return string.Concat(File ? this.Path1
                    : string.Concat(
                        MissingFolder ? "MISSING FOLDER: " : "",
                        MissingFile ? "MISSING FILE: " : "",
                        Path1
                    ),
                "(", this.Diff ? "diff " : "", this.ContentDiff.ToString(),")");
            }
        }

        enum ContentDiff
        {
            Unknown,
            Checking,
            Diff,
            Same,
            Error,
            NotAFile
        }

        public void ResetComparison()
        {
            string se = string.Empty;
            listBox1.DataSource = null;
            lblFile1Name.Text = se;
            lblFile2Name.Text = se;
            txtFile1Contents.Text = se;
            txtFile1Created.Text = se;
            txtFile1Modified.Text = se;
            txtFile2Contents.Text = se;
            txtFile2Created.Text = se;
            txtFile2Modified.Text = se;
        }

        private void btnOpenFolder1_Click(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            if (Directory.Exists(this.txtFolder1.Text)) f.SelectedPath = txtFolder1.Text;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtFolder1.Text = f.SelectedPath;
                if (txtFolder2.Text == @"C:\git\project2") txtFolder2.Text = f.SelectedPath;
            }
        }

        private void btnOpenFolder2_Click(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            if (Directory.Exists(this.txtFolder2.Text)) f.SelectedPath = txtFolder2.Text;
            if (f.ShowDialog() == DialogResult.OK)
                txtFolder2.Text = f.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0) return;
                var item = (FileComparison)listBox1.Items[listBox1.SelectedIndex];
                var item2 = (FileComparison)listBox1.SelectedItem;
                this.lblFile1Name.Text = item.Path1;
                this.lblFile2Name.Text = item.Path2;
                if (item.File1Created != item.File2Created)
                {
                    txtFile1Created.Text = item.File1Created.ToString();
                    txtFile2Created.Text = item.File2Created.ToString();
                }
                if (item.File1Modified != item.File2Modified)
                {
                    txtFile1Modified.Text = item.File1Modified.ToString();
                    txtFile2Modified.Text = item.File2Modified.ToString();
                }

                // refactor, lägg till en knapp "compare all" och filterara pådet!!
                if (true || this.contentDiffFilter)
                {
                    ReadFileContents((FileComparison)this.listBox1.SelectedItem);
                }
                //ReadFileContents(item);
            }
            catch (Exception ex)
            {
                txtFile1Contents.Text = ex.ToString();
            }
        }

        private ContentDiff ReadFileContents(FileComparison item, bool showFileContents = true)
        {
            string c1 = "", c2 = "";
            item.ContentDiff = ContentDiff.Checking;
            if (item.File)
            {
                try
                {
                    c1 = File.ReadAllText(item.Path1);
                }
                catch (Exception ex)
                {
                    this.txtFile1Contents.Text = "Unable to open file: " + ex.ToString();
                    item.ContentDiff = ContentDiff.Error;
                    return item.ContentDiff;
                }

                try
                {
                    c2 = File.ReadAllText(item.Path2);
                }
                catch (Exception ex)
                {
                    this.txtFile2Contents.Text = "Unable to open file: " + ex.ToString();
                    item.ContentDiff = ContentDiff.Error;
                    return item.ContentDiff;
                }
            }
            else
            {
                item.ContentDiff = ContentDiff.NotAFile;
                if (showFileContents)
                {
                    this.txtFile1Contents.Text = item.MissingFile ? "Missing file" : "Missing folder";
                }
            }
            if (c1 != c2)
            {
                item.ContentDiff = ContentDiff.Diff;
                if (showFileContents)
                {

                    try
                    {
                        this.txtFile1Contents.Text = Diff(c1, c2) + Environment.NewLine + Environment.NewLine + c1;
                    }
                    catch (Exception ex)
                    {
                        this.txtFile1Contents.Text = "Diff failed: " + ex.ToString() + Environment.NewLine + Environment.NewLine + c1;
                    }
                    this.txtFile2Contents.Text = c2;
                }
            }
            else
            {
                item.ContentDiff = ContentDiff.Same;
                if (showFileContents)
                {
                    this.txtFile1Contents.Text = "(same)";
                    this.txtFile2Contents.Text = "(same)";
                }
            }
            return item.ContentDiff;
        }

        private string Diff(string c1, string c2)
        {
            Func<DiffPlex.DiffBuilder.Model.ChangeType, string> TypeToString = x => 
                x == DiffPlex.DiffBuilder.Model.ChangeType.Deleted ? "- " :
                x == DiffPlex.DiffBuilder.Model.ChangeType.Imaginary ? "<i>" :
                x == DiffPlex.DiffBuilder.Model.ChangeType.Inserted ? "+" :
                x == DiffPlex.DiffBuilder.Model.ChangeType.Modified ? "m" :
                "<unchanged>";

            var diff = this.diffBuilder.BuildDiffModel(c1, c2);
            var diffingLines = diff.Lines
                .Where(l => l.Type != DiffPlex.DiffBuilder.Model.ChangeType.Unchanged);
            return diffingLines.Any() ?
                diffingLines
                .Select(l => string.Concat(l.Position, " ", TypeToString(l.Type), l.Text))
                .Aggregate((a, b) => string.Concat(a, Environment.NewLine, b))
            : "(same)";
        }

        private void FilterFiles()
        {
            if (files.Any())
            {
                bool doNotFilter = rdoFilterOff.Checked;
                bool filterOut = rdoFilterExcludeExtensions.Checked;
                string selected = listBox1.SelectedItem == null ? "" : ((FileComparison)listBox1.SelectedItem).Filename;
                var filteredFiles = doNotFilter ? this.files.ToList()
                    : this.files
                    .Where(f =>
                        filterOut ? !this.ignoreFileTypes.Select(t => t.ToLower()).Contains(Path.GetExtension(f.Filename).ToLower())
                        : this.ignoreFileTypes.Select(t => t.ToLower()).Contains(Path.GetExtension(f.Filename).ToLower())
                    )
                    .Where(f =>
                        this.contentDiffFilter && f.ContentDiff == ContentDiff.Diff || !this.contentDiffFilter || !f.File
                    ).ToList();
                listBox1.DataSource = filteredFiles;
                if (selected != "" && !this.ignoreFileTypes.Select(t => t.ToLower()).Contains(Path.GetExtension(selected.ToLower())) && filteredFiles.Any(f => f.Filename == selected))
                {
                    listBox1.SelectedItem = this.files.Where(f => f.Filename == selected).First();
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                }
            }
            this.lblFileCount.Text = string.Format("{0} objects in {1} list", this.listBox1.Items.Count, rdoFilterOff.Checked ? "unfiltered" : "filtered");
        }

        private void rdoFilterOn_CheckedChanged(object sender, EventArgs e)
        {
            FilterFiles();
        }

        private void rdoFilterOff_CheckedChanged(object sender, EventArgs e)
        {
            this.contentDiffFilter = false;
            FilterFiles();
        }

        private void rdoFilterOnlyTheseExtensions_CheckedChanged(object sender, EventArgs e)
        {
            FilterFiles();
        }

        private void btnAddFileType_Click(object sender, EventArgs e)
        {
            string ext = txtAddFileType.Text;
            if (this.ignoreFileTypes.Contains(ext)) return;
            this.listBox2.DataSource = null;
            this.ignoreFileTypes.Add(ext);
            this.listBox2.DataSource = this.ignoreFileTypes;
            this.listBox2.SelectedItem = ext;
            FilterFiles();
        }

        private void btnRemoveFileType_Click(object sender, EventArgs e)
        {
            string ext = txtAddFileType.Text;
            if (!this.ignoreFileTypes.Contains(ext)) return;
            this.listBox2.DataSource = null;
            this.ignoreFileTypes.Remove(ext);
            this.listBox2.DataSource = this.ignoreFileTypes;
            FilterFiles();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtAddFileType.Text = (string)this.listBox2.SelectedItem;
        }

        private void btnNotepadPlusPlus_Click(object sender, EventArgs e)
        {
            var selectedItem = (FileComparison)this.listBox1.SelectedItem;
            if (!selectedItem.File) return;
            try
            {
                string program = @"C:\Program Files (x86)\Notepad++\plugins\ComparePlugin\compare.exe";
                string files = string.Format(@"""{0}"" ""{1}""", selectedItem.Path1, selectedItem.Path2);
                Process.Start(
                    program,
                    files
                    );

            }
            catch (Exception ex)
            {
                this.txtFile1Contents.Text = ex.ToString();
            }
        }

        private void btnCompareAll_Click(object sender, EventArgs e)
        {
            this.progressBar1.Step = 1;
            this.progressBar1.Maximum = this.files.Count();
            this.progressBar1.Value = 0;
            foreach (var f in this.files)
            {
                var d = ReadFileContents(f, false);
                this.progressBar1.Value++;
                this.progressBar1.Refresh();
                string r = "";
            }
            var not_unknown = this.files.Where(f => f.ContentDiff != ContentDiff.Unknown);
            var ls = not_unknown.Select(f => f.ContentDiff.ToString()).ToArray();
            this.contentDiffFilter = true;
            FilterFiles();
        }
    }
}

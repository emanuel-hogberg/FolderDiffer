using DiffPlex;
using DiffPlex.DiffBuilder;using System;
using Extensions;
using FolderDiffer.Filters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FolderDiffer
{
    public partial class FileComparer : Form
    {
        public FileComparer()
        {
            model = new FileComparisonModel()
                .AddFilter(new FileExtensionFilter().AssignForward(out fileExtensionFilter))
                .AddFilter(new ContentFilter().AssignForward(out contentFilter))
                .AddFilter(new RegexFilter().AssignForward(out regexFilter))
                .AddFilter(new ModifiedDateFilter().AssignForward(out modifiedAfterFilter));

            InitializeComponent();
            ResetComparison();
            rdoFilterOff.Checked = true;
            fileExtensionFilter.IgnoreFileTypes.AddRange(new string[]
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
            listBox2.DataSource = fileExtensionFilter.IgnoreFileTypes;
            btnCompareFolders.Select();
            txtFolder1.Text = @"C:\git\project1";
            txtFolder2.Text = @"C:\git\project2";
            var d = new Differ();
        }

        FileComparisonModel model;
        InlineDiffBuilder diffBuilder = new InlineDiffBuilder(new Differ());

        RegexFilter regexFilter;
        ModifiedDateFilter modifiedAfterFilter;
        ContentFilter contentFilter;
        FileExtensionFilter fileExtensionFilter;

        private void btnCompareFolders_Click(object sender, EventArgs e)
        {
            CompareFolders();
        }

        private void CompareFolders()
        {
            try
            {
                ResetComparison();
            }
            catch (Exception ex)
            {
                txtFile1Contents.Text = ex.ToString();
                return;
            }

            if (txtFolder1.Text == txtFolder2.Text)
            {
                txtFile1Contents.Text = "It's the same folder.";
                return;
            }
            var comparisons = OpenFolder(txtFolder1.Text, txtFolder2.Text);
            model.Files = comparisons.ToList();
            listBox1.DataSource = comparisons.ToList();
            InitDateTreeNodes();
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

            foreach(string folder in folders1
                .Where(f => !missingFolders.Contains(f) && !fileExtensionFilter.GetIgnoreFolders().Contains(Path.GetFileName(f).ToLower())))
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
                txtFile1Contents.Text = ex.ToString();
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
                txtFile1Contents.Text = ex.ToString();
            }
            return new List<FileComparison>();
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
            rdoCompareAllOn.Enabled = false;
            rdoCompareAllOff.Enabled = false;
            rdoCompareAllOff.Checked = true;
            lblFile1Created.ForeColor = Color.Black;
            lblFile1Modified.ForeColor = Color.Black;
            lblFile2Created.ForeColor = Color.Black;
            lblFile2Modified.ForeColor = Color.Black;
            treeDates.Nodes.Clear();
        }

        private void btnOpenFolder1_Click(object sender, EventArgs e)
        {
            OpenFolder1();
        }

        private void btnOpenFolder2_Click(object sender, EventArgs e)
        {
            OpenFolder2();
        }

        private void OpenFolder1()
        {
            txtFolder1.Text = txtFolder1.Text.Replace("/", "\\");
            var f = new FolderBrowserDialog();
            if (Directory.Exists(txtFolder1.Text)) f.SelectedPath = txtFolder1.Text;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtFolder1.Text = f.SelectedPath;
                if (txtFolder2.Text == @"C:\git\project2") txtFolder2.Text = f.SelectedPath;
            }
        }

        private void OpenFolder2()
        {
            txtFolder2.Text = txtFolder2.Text.Replace("/", "\\");
            var f = new FolderBrowserDialog();
            if (Directory.Exists(txtFolder2.Text)) f.SelectedPath = txtFolder2.Text;
            if (f.ShowDialog() == DialogResult.OK)
                txtFolder2.Text = f.SelectedPath;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0) return;
                var item = (FileComparison)listBox1.Items[listBox1.SelectedIndex];
                var item2 = (FileComparison)listBox1.SelectedItem;
                lblFile1Name.Text = item.Path1;
                lblFile2Name.Text = item.Path2;
                lblFile1Created.ForeColor = Color.Black;
                lblFile1Modified.ForeColor = Color.Black;
                lblFile2Created.ForeColor = Color.Black;
                lblFile2Modified.ForeColor = Color.Black;
                txtFile1Created.Text = item.File1Created.ToString();
                txtFile1Modified.Text = item.File1Modified.ToString();
                if (item.File1Created.ToString() != item.File2Created.ToString())
                {
                    txtFile2Created.Text = item.File2Created.ToString();
                    if (item.File1Created > item.File2Created)
                    {
                        lblFile1Created.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblFile2Created.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtFile2Created.Text = "(same)";
                }
                if (item.File1Modified.ToString() != item.File2Modified.ToString())
                {
                    txtFile2Modified.Text = item.File2Modified.ToString();
                    if (item.File1Modified > item.File2Modified)
                    {
                        lblFile1Modified.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblFile2Modified.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtFile2Modified.Text = "(same)";
                }

                ReadFileContents((FileComparison)listBox1.SelectedItem);
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
                    txtFile1Contents.Text = "Unable to open file: " + ex.ToString();
                    item.ContentDiff = ContentDiff.Error;
                    return item.ContentDiff;
                }

                try
                {
                    c2 = File.ReadAllText(item.Path2);
                }
                catch (Exception ex)
                {
                    txtFile2Contents.Text = "Unable to open file: " + ex.ToString();
                    item.ContentDiff = ContentDiff.Error;
                    return item.ContentDiff;
                }
            }
            else
            {
                item.ContentDiff = ContentDiff.NotAFile;
                if (showFileContents)
                {
                    txtFile1Contents.Text = item.MissingFile ? "Missing file" : "Missing folder";
                }
            }
            if (c1 != c2)
            {
                item.ContentDiff = ContentDiff.Diff;
                if (showFileContents)
                {

                    try
                    {
                        txtFile1Contents.Text = Diff(c1, c2) + Environment.NewLine + Environment.NewLine + c1;
                    }
                    catch (Exception ex)
                    {
                        txtFile1Contents.Text = "Diff failed: " + ex.ToString() + Environment.NewLine + Environment.NewLine + c1;
                    }
                    txtFile2Contents.Text = c2;
                }
            }
            else
            {
                item.ContentDiff = ContentDiff.Same;
                if (showFileContents)
                {
                    txtFile1Contents.Text = "(same)";
                    txtFile2Contents.Text = "(same)";
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

            var diff = diffBuilder.BuildDiffModel(c1, c2);
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
            if (model.Files.Any())
            {
                string selected = listBox1.SelectedItem == null ? "" : ((FileComparison)listBox1.SelectedItem).Filename;
                List<FileComparison> filteredFiles = model.FilterFiles();
                listBox1.DataSource = filteredFiles;
                var ignoreTypes = fileExtensionFilter.IgnoreFileTypes.Select(t => t.ToLower());
                bool fileSelected = filteredFiles.Any(f => f.Filename == selected);
                if (selected != "" && !ignoreTypes.Contains(Path.GetExtension(selected.ToLower())) && fileSelected)
                {
                    listBox1.SelectedItem = model.Files.Where(f => f.Filename == selected).First();
                }
                else if (listBox1.Items.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                }
            }
            lblFileCount.Text = string.Format("{0} objects in {1} list", listBox1.Items.Count, rdoFilterOff.Checked ? "unfiltered" : "filtered");
        }

        private void SetupFileExtensionFilter()
        {
            fileExtensionFilter.Active = !rdoFilterOff.Checked;
            fileExtensionFilter.FilterOut = rdoFilterExcludeExtensions.Checked;
        }

        private void rdoFilterOn_CheckedChanged(object sender, EventArgs e)
        {
            SetupFileExtensionFilter();
            FilterFiles();
        }

        private void rdoFilterOff_CheckedChanged(object sender, EventArgs e)
        {
            SetupFileExtensionFilter();
            FilterFiles();
        }

        private void rdoFilterOnlyTheseExtensions_CheckedChanged(object sender, EventArgs e)
        {
            SetupFileExtensionFilter();
            FilterFiles();
        }

        private void btnAddFileType_Click(object sender, EventArgs e)
        {
            string ext = txtAddFileType.Text;
            if (fileExtensionFilter.IgnoreFileTypes.Contains(ext)) return;
            listBox2.DataSource = null;
            fileExtensionFilter.IgnoreFileTypes.Add(ext);
            listBox2.DataSource = fileExtensionFilter.IgnoreFileTypes;
            listBox2.SelectedItem = ext;
            FilterFiles();
        }

        private void btnRemoveFileType_Click(object sender, EventArgs e)
        {
            string ext = txtAddFileType.Text;
            if (!fileExtensionFilter.IgnoreFileTypes.Contains(ext)) return;
            listBox2.DataSource = null;
            fileExtensionFilter.IgnoreFileTypes.Remove(ext);
            listBox2.DataSource = fileExtensionFilter.IgnoreFileTypes;
            FilterFiles();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddFileType.Text = (string)listBox2.SelectedItem;
        }

        private void btnNotepadPlusPlus_Click(object sender, EventArgs e)
        {
            var selectedItem = (FileComparison)listBox1.SelectedItem;
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
                txtFile1Contents.Text = ex.ToString();
            }
        }

        private void btnCompareAll_Click(object sender, EventArgs e)
        {
            if (!model.Files.Any()) return;
            progressBar1.Step = 1;
            progressBar1.Maximum = model.Files.Count();
            progressBar1.Value = 0;
            foreach (var f in model.Files)
            {
                var d = ReadFileContents(f, false);
                progressBar1.Value++;
                progressBar1.Refresh();
                string r = "";
            }
            var not_unknown = model.Files.Where(f => f.ContentDiff != ContentDiff.Unknown);
            var ls = not_unknown.Select(f => f.ContentDiff.ToString()).ToArray();
            rdoCompareAllOn.Enabled = true;
            rdoCompareAllOn.Checked = true;
            rdoCompareAllOff.Enabled = true;
            FilterFiles();
        }

        private void txtRegexFilter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRegexFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                UpdateRegex();
        }

        private void txtRegexFilter_Leave(object sender, EventArgs e)
        {
            UpdateRegex();
        }

        private void UpdateRegex()
        {
            if (string.IsNullOrEmpty(txtRegexFilter.Text))
            {
                regexFilter.Regex = null;
                return;
            }

            regexFilter.Regex = new Regex(txtRegexFilter.Text, RegexOptions.IgnoreCase);

            try
            {
                // try regex
                new[] { "test1", "test123" }.ToList()
                    .ForEach(s =>
                        regexFilter.Regex.IsMatch(s));
                FilterFiles();
            }
            catch (Exception ex)
            {
                txtFile1Contents.Text = "Regex not valid: " + ex.ToString();
            }
        }

        private void txtFolder1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                OpenFolder1();
        }

        private void txtFolder2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                if (!string.IsNullOrWhiteSpace(txtFolder2.Text) && Directory.Exists(txtFolder2.Text))
                {
                    CompareFolders();
                }
                else
                {
                    OpenFolder2();
                }
            }
        }

        private void rdoCompareAllOn_CheckedChanged(object sender, EventArgs e)
        {
            contentFilter.Active = !rdoCompareAllOff.Checked && rdoCompareAllOn.Enabled;
            FilterFiles();
        }

        private void rdoCompareAllOff_CheckedChanged(object sender, EventArgs e)
        {
            FilterFiles();
        }

        private void txtModifiedAfterFilter_Enter(object sender, EventArgs e)
        {
            txtModifiedAfterFilter.Text = DateTime.Today.ToString();
        }

        private void txtModifiedAfterFilter_Leave(object sender, EventArgs e)
        {
            UpdateModifiedAfterFilter();
        }

        private void txtModifiedAfterFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                UpdateModifiedAfterFilter();
        }

        private void UpdateModifiedAfterFilter()
        {
            txtModifiedAfterFilter.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(txtModifiedAfterFilter.Text))
            {
                modifiedAfterFilter.Value = null;
                return;
            }

            if (DateTime.TryParse(txtModifiedAfterFilter.Text, out DateTime result))
            {
                modifiedAfterFilter.Value = result;
                FilterFiles();
            }
            else
            {
                txtModifiedAfterFilter.ForeColor = Color.Red;
            }
        }

        private void InitDateTreeNodes()
        {
            var modifiedFiles = model.Files
                .Select(file => new { Mod1 = file.File1Modified > file.File1Created ? file.File1Modified : file.File1Created, Mod2 = file.File2Modified > file.File2Created ? file.File2Modified : file.File2Created, File = file })
                .Select(f => new { Modified = f.Mod1 > f.Mod2 ? f.Mod2 : f.Mod1, File = f.File })
                .Where(f => f.File.File)
                .ToArray();
            var modDays = modifiedFiles
                .Select(f => f.Modified)
                .GroupBy(d => d.Date.ToString("yyyy-MM-dd"), d => d.ToString("HH:mm"))
                .OrderByDescending(g => g.Key);

            var nodes = modDays
                .Select(day =>
                    new TreeNode(day.Key,
                        day
                        .OrderByDescending(d => d)
                        .Distinct()
                        .Select(date => new TreeNode(date))
                        .ToArray()
                    )
                )
                .ToArray();
            treeDates.Nodes.AddRange(nodes);
        }

        private void treeDates_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string mod = e.Node.Text;
            if (mod.Length < 10 && e.Node.Parent != null)
                mod = string.Concat(e.Node.Parent.Text, " ", mod);

            txtModifiedAfterFilter.Text = mod;
            UpdateModifiedAfterFilter();
        }
    }
}

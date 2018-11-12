using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderDiffer
{
    public class FileComparison
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
            "(", this.Diff ? "diff " : "", this.ContentDiff.ToString(), ")");
        }
    }
}

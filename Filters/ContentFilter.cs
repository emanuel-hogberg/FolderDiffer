using System.Collections.Generic;
using System.Linq;

namespace FolderDiffer.Filters
{
    public class ContentFilter : Filter
    {
        public bool Active { get; set; }
        internal override IEnumerable<FileComparison> Apply(IEnumerable<FileComparison> files)
            => Active ?
            files.Where(f =>
                f.ContentDiff == ContentDiff.Diff ||
                f.ContentDiff == ContentDiff.Error ||
                f.ContentDiff == ContentDiff.Unknown ||
                !f.File)
            : files;
    }
}

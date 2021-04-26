using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderDiffer.Filters
{
    public class RegexFilter : Filter
    {
        public Regex Regex { get; internal set; }

        internal override IEnumerable<FileComparison> Apply(IEnumerable<FileComparison> files)
        => Regex != null ? files.Where(f => Regex.IsMatch(f.Path1) || Regex.IsMatch(f.Path1)) : files;
    }
}

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderDiffer.Filters
{
    public class FileExtensionFilter : Filter
    {
        public bool Active { get; set; }
        public bool FilterOut { get; set; }
        private FileComparisonModel model;
        internal override IEnumerable<FileComparison> Apply(IEnumerable<FileComparison> files)
        {
            if (!Active) return files.ToList();

            var matchingExtensions = files
                .Where(f => IgnoreFileTypes.Select(t => t.ToLower()).Contains(Path.GetExtension(f.Filename).ToLower()));

            return (FilterOut ?
                        files.Except(matchingExtensions)
                        : matchingExtensions).ToList();
        }

        public List<string> IgnoreFileTypes { get; set; } = new List<string>();
        public IEnumerable<string> GetIgnoreFolders()
        {
            return IgnoreFileTypes.Where(t => t.StartsWith("\\")).Select(t => t.Substring(1).ToLower());
        }
    }
}

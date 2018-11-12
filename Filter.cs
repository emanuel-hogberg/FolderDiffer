using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderDiffer.Filters
{
    public class Filter
    {
        public Filtering Apply(Filtering filtering)
        {
            return filtering.Filter(this);
        }

        internal virtual IEnumerable<FileComparison> Apply(IEnumerable<FileComparison> files)
        {
            return files;
        }
    }

    public sealed class Filtering
    {
        private bool filtered = false;
        private IEnumerable<FileComparison> files;

        public Filtering(List<FileComparison> files)
        {
            this.files = files;
        }

        internal Filtering Filter(Filter filter)
        {
            files = filter.Apply(files);
            filtered = true;
            return this;
        }

        internal List<FileComparison> FilteredFiles()
        {
            if (!filtered)
                throw new Exception("Filter not applied!");
            return files.ToList();
        }
    }
}

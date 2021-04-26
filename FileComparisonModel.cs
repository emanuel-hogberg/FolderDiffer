using FolderDiffer.Filters;
using System.Collections.Generic;
using System.Linq;

namespace FolderDiffer
{
    class FileComparisonModel
    {

        public List<FileComparison> Files { get; set; } = new List<FileComparison>();
        private LinkedList<Filter> filters = new LinkedList<Filter>();

        public FileComparisonModel AddFilter(Filter filter)
        {
            filters.AddLast(filter);
            return this;
        }

        public List<FileComparison> FilterFiles()
        {
            var filtering = new Filtering(Files);
            filters.Aggregate(filtering, (acc, filter) => filter.Apply(acc));
            return filtering.FilteredFiles();
        }

    }
}

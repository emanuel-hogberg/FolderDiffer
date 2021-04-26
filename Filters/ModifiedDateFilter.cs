using System;
using System.Collections.Generic;
using System.Linq;

namespace FolderDiffer.Filters
{
    public class ModifiedDateFilter : Filter
    {
        public bool HasValue { get => Value.HasValue; }
        public DateTime? Value { get; set; }

        internal override IEnumerable<FileComparison> Apply(IEnumerable<FileComparison> files)
        => HasValue ? files.Where(f => f.File1Modified >= Value || f.File2Modified >= Value) : files;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderDiffer
{
    public enum ContentDiff
    {
        Unknown,
        Checking,
        Diff,
        Same,
        Error,
        NotAFile
    }
}

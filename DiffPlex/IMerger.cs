//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    /// <summary>
    ///  This is created for tetsing the summary.
    /// [AltNameToLink](IDiffer.cs)
    ///</summary>
    public interface IMerger
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

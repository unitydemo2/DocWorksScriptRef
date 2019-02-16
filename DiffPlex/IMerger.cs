//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    /// <summary>
       ///   Content is updated only for testing pull is working fine or not for scriptref projects.
    ///  </summary>

    public interface IMerger
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

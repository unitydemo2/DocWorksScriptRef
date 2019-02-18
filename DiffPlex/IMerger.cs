//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    /// <summary>
       /// SIRSENDU TEST ---  Content is updated only for testing pull is working fine or not for scriptref projects on 18th Feb 2018.
    ///  </summary>

    public interface IMerger
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

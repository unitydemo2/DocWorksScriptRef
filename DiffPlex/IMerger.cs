//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    /// <summary>
        /// ```
        ///  Class ABC {
        ///  Int a;
        ///  Int b;
        ///  }
        /// ```
        /// </summary>
        /// <description>
        /// ```
        ///  Class ABC {
        ///  Int a;
        ///  Int b;
        ///  }
        /// ```
        /// </description>
            public interface IMerger
    {
        
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

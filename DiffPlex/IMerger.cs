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
                /// <br/>  ![](The-power-of-unity_5c74fb73bf9f0a0194bb1e0d.png)<br/>  [5c750355bf9f0a0194bb92fc](adding_5c750355bf9f0a0194bb92fc.cs)<br/> <br/>  
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

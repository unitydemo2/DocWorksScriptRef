//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    /// <description>
    /// `<br/> Class ABC {<br/> Int b;<br/> Int a;<br/> }<br/>`
    /// </description>
    public interface IMerger
    {
        
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

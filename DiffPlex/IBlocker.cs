using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    public interface IBlocker
    {              
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

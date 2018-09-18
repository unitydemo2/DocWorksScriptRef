using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    
    
    public class DiffPaneModel
    {
        
        
        
        public List<DiffPiece> Lines { get; }

        
        
        /// <summary>
        /// ![](test45_5b9f39c873e69b0454e7d054.jpg)
        /// </summary>
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
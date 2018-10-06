using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <summary>
    /// This is the summary for DiffPane Model
    /// </summary>
        public class DiffPaneModel
    {
        
        
        /// <summary>
        /// ![](png_5bb5942b84d9ef020c737cd9.png)
        /// </summary>
        public List<DiffPiece> Lines { get; }

        
        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
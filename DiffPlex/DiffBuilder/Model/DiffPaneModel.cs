using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <summary>
    /// This is the summary for DiffPane Model
    /// </summary>
    public class DiffPaneModel
    {
        
        
        public List<DiffPiece> Lines { get; }

        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
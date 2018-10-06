using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <Summary>
    /// This box is edited for testing push
    /// </Summary>
    public class DiffPaneModel
    {
        
        
        public List<DiffPiece> Lines { get; }

        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
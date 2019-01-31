using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
        ///     <summary>
        ///     SOME TEST SUMMARY
        ///     </summary>
    public class DiffPaneModel
    {
        
        public List<DiffPiece> Lines { get; }

        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}

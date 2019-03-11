using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
        ///      <summary>
            ///       This is created for tetsing the summary.
            ///      ![Image](Fish_5c7509e9bf9f0a0194bc06fb.jpeg)
            ///      ![Code](escape_5c754060bf9f0a0194bc200a.cs)
            ///      Assets Added here for pull testing.
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

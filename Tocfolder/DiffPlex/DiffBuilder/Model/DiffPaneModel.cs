using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    
    
    
    
    public class DiffPaneModel
    {
        /// <summary>
        /// Test abc ![abc](Enfiled_5b6c27ce5b416027c012a509.jpg) qwe asdfasfa  <dw-code>5b6c27ce5b416027c012a50a<dw-code></dw-code></dw-code>
        /// </summary>
                                        public List<DiffPiece> Lines { get; }

        
        
        
        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
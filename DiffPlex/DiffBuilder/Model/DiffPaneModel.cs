using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    public class DiffPaneModel
    {
        /// <summary>
        /// **Madhu** is *testing* this for the ***last time.***
        /// </summary>
        public List<DiffPiece> Lines { get; }

        /// <summary>
        /// <br>*  Test1</br> <br>*  Test2</br> <br>*  Test3 </br>
        /// </summary>
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
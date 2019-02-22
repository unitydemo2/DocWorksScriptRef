using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <summary>
        /// The BurstDiscard attribute lets you remove a method or property from being compiled to native code by the burst compiler.
        /// </summary>
        /// <description>
        /// [5c6beeef6cab410504049596](2D01_5c6beeef6cab410504049596.cs)
        /// </description>
            public class DiffPaneModel
    {
        
        
        
        public List<DiffPiece> Lines { get; }

        
        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
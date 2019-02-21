using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    
    /// <summary>
    /// The BurstDiscard attribute lets you remove a method or property from being compiled to native code by the burst compiler.
    /// </summary>
    /// <description>
    /// [5c6be5da6cab4105040479da](hello_5c6be5da6cab4105040479da.cs)
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
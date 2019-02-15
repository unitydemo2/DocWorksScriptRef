namespace DiffPlex.Model
{
    ///<summary>
       ///   This node is created for testing DW-3588 sub task.
    ///</summary>
    
    public class PulledNode
    {
        
        public int[] HashedPieces { get; set; }

        
        public string RawData { get; }

        
        public bool[] Modifications { get; set; }

        
        public string[] Pieces { get; set; }

        
        public PulledNode(string str)
        {
            RawData = str;
        }
    }
}

namespace DiffPlex.Model
{
    ///<summary>
       ///   This node is created for testing DW-3588 sub task.
    ///</summary>
    
    public class PulledNode11
    {
        
        public int[] HashedPieces { get; set; }

        
        public string RawData { get; }

        
        public bool[] Modifications { get; set; }

        
        public string[] Pieces { get; set; }

        
        public PulledNode11(string str)
        {
            RawData = str;
        }
    }
}

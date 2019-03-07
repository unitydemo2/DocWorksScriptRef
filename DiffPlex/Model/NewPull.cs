namespace DiffPlex.Model
{
    
    /// <summary>
    ///  This is created for tetsing the summary.
    /// [CMS link from source controller for scriptref](IMerger.cs)
    /// Link created for testing
    ///</summary>
    public class NewPull
    {
        
        public int[] HashedPieces { get; set; }

        
        public string RawData { get; }

        
        public bool[] Modifications { get; set; }

        
        public string[] Pieces { get; set; }

        
        public NewPull(string str)
        {
            RawData = str;
        }
    }
}

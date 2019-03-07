namespace DiffPlex.Model
{
    
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

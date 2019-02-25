namespace DiffPlex.Model
{
    
    public class ModificationData
    {
        
        public int[] HashedPieces { get; set; }

        
        public string RawData { get; }

        
        public bool[] Modifications { get; set; }

        
        public string[] Pieces { get; set; }

        
        public ModificationData(string str)
        {
            RawData = str;
        }
        
        public delegate int TestDelegate1221(string s);

        public delegate void CalculateSquare1221(double number);
        
    }
}

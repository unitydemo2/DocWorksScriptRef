namespace DiffPlex.Model
{
        /// <summary>
        ///  This is created for testing the summary.
        ///</summary>
        ///<description>
        /// This is created for tetsing the description.
        ///![abc](QAImages/test5.jpg)
        /// </description>
        
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
    }
}

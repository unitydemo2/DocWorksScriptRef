namespace DiffPlex.Model
{
    
    public enum Edit
    {
        
        None,
        
        DeleteRight,
        
        DeleteLeft,
        
        InsertDown,
        
        InsertUp
    }

    /// <summary>
        ///  This is created for testing the summary.
        ///</summary>
        ///<description>
        /// This is created for tetsing the description.
        ///![abc](test5.jpg)
        /// </description>
        
    public class PulledNodeGH
    {
        
        public int EditLength { get; set; }

        
        public int StartX { get; set; }
        
        public int EndX { get; set; }
        
        public int StartY { get; set; }
        
        public int EndY { get; set; }

        
        public Edit LastEdit { get; set; }
    }
}

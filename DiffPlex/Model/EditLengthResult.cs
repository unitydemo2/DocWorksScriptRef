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
        /// This is created for testing
        /// </summary>
        /// <description>
        /// ![abc](301805_5c6b9b40c6f96208d4f086d7.jpg)
        /// </description>
            public class EditLengthResult
    {
        
        /// <summary>
                /// [5c6ba89d6cab41050403d54d](TG1_5c6ba89d6cab41050403d54d.cs)
                /// </summary>
                /// <description>
                /// []()
                /// </description>
                        public int EditLength { get; set; }

        
        
        
        public int StartX { get; set; }
        
        
        
        public int EndX { get; set; }
        
        
        
        public int StartY { get; set; }
        
        
        
        public int EndY { get; set; }

        
        
        
        public Edit LastEdit { get; set; }
    }
}
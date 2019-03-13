namespace DiffPlex.Model
{
    
    /// <summary>
    /// Testing draft
    /// </summary>
    /// <description>
    /// Adding new "Code Block" and “Image” to the description<br/>  Image1 ![](moon_5c74fc03bf9f0a0194bb1e30.jpeg)<br/>  Code Block1 [5c75226ebf9f0a0194bc0b28](code_1_5c75226ebf9f0a0194bc0b28.cs)<br/>  Image2 ![](AsyncCompute-0_5c74fe40a66a08177c1c0b02.png)<br/>  Code Block2 [5c754060bf9f0a0194bc200a](escape_5c754060bf9f0a0194bc200a.cs)<br/>  CMS link2 <br/>  []()
    /// </description>
    public enum Edit
    {
        
        
        None,
        
        
        DeleteRight,
        
        
        DeleteLeft,
        
        
        InsertDown,
        
        /// <summary>
        /// Image2 ![](AsyncCompute-0_5c74fe40a66a08177c1c0b02.png)<br/>  Code Block2 [5c754060bf9f0a0194bc200a](escape_5c754060bf9f0a0194bc200a.cs)<br/>  CMS link2 <br/>  []()
        /// </summary>
        InsertUp
    }

    
    public class EditLengthResult
    {
        
        public int EditLength { get; set; }

        
        public int StartX { get; set; }
        
        public int EndX { get; set; }
        
        public int StartY { get; set; }
        
        public int EndY { get; set; }

        
        public Edit LastEdit { get; set; }
    }
}
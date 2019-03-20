using System;

namespace DiffPlex
{

   
    public class SampleClass
    {
        private static readonly string[] emptyStringArray = new string[0];
        ///     <summary>
        ///     this is the property for 
        ///         ![Enfield image](Enfiled.jpg)
        ///     </summary>
                
        public string PropertyForTesting { get; set; }

        
        
        
        public string CreateSomeOutput(string oldText, string newText, bool ignoreWhitespace)
        {
            return "Test Output";
        }
    }
}

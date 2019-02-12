using System;

namespace DiffPlex
{
    
    
    
    [Obsolete]
    public class AloksTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
                                                                /// this is the property for test
                                                                /// </summary>
                                                                /// <description>
                                                                /// This is the description <br>  for property
                                                                /// </description>
                                                                                                                        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        
        
        
        public string CompareString(string oldText, string newText, bool ignoreWhitespace)
        {
            if (oldText.Equals(newText))
                return "strings are equal";
            else
                return "not equal";
        }

        /// <summary>
                                                                /// this method is to find diffs in 2 texts
                                                                /// </summary>
                                                                /// <param name="oldText">
                                                                /// this param is for existing text
                                                                /// </param>
                                                                /// <param name="newText">
                                                                /// this param is for updated text
                                                                /// </param>
                                                                                                                        [Obsolete]
        public bool CompareStringLength(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase)
        {
            if (oldText == null) throw new ArgumentNullException(nameof(oldText));
            if (newText == null) throw new ArgumentNullException(nameof(newText));
            return oldText.Length > newText.Length;
        }

        
        
        
        public string CreateSomeOutput(string oldText, string newText, bool ignoreWhitespace)
        {
            return "Test Output";
        }
    }
}

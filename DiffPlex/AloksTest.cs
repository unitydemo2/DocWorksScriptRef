using System;

namespace DiffPlex
{
    
    
    [Obsolete]
    public class AloksTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
                                /// this is the property for updating<br>  Another summary line
                                /// </summary>
                                /// <description>
                                /// Adding description<br>  In another line success
                                /// </description>
                                                        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        
        /// <summary>
        /// This method will compare two string
        /// </summary>
        /// <description>
        /// This method has been written so that,<br>  It can compare two strings and return the output, also you can specify whether it should check space or not.
        /// </description>
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

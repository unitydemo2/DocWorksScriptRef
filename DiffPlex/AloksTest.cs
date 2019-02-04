using System;

namespace DiffPlex
{
    
    /// <summary>
    /// </summary>
    /// <description>
    /// </description>
    [Obsolete]
    public class AloksTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
                                /// this is the property for
                                /// </summary>
                                /// <description>
                                /// </description>
                                                        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        
        /// <summary>
        /// </summary>
        /// <description>
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
                                /// <description>
                                /// </description>
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

        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        public string CreateSomeOutput(string oldText, string newText, bool ignoreWhitespace)
        {
            return "Test Output";
        }
    }
}

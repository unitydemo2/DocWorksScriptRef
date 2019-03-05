using System;

namespace DiffPlex
{
    
    /// <description>
    /// ![Tiger eyes image](Eyes_5c7d098562472f50dc7bac49.jpg)
    /// </description>
    [Obsolete]
    public class AloksSummaryTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
                                /// this is the property for
                                /// </summary>
                                                        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        
        /// <summary>
        /// ![abc](DW5a963922d2f2b83b4ce3e9c6_5c669d117f229462684627ac.png)
        /// </summary>
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
                                                        [Obsolete]
        public bool CompareStringLength(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase)
        {
            if (oldText == null) throw new ArgumentNullException(nameof(oldText));
            if (newText == null) throw new ArgumentNullException(nameof(newText));
            return oldText.Length > newText.Length;
        }

        /// <summary>
                                /// This is a test description for this method
                                /// </summary>
                                /// <returns>
                                /// Method returns a string
                                /// </returns>
                                                        public string CreateSomeOutput(string oldText, string newText, bool ignoreWhitespace)
        {
            return "Test Output";
        }
    }
}

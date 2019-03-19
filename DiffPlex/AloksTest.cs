using System;

namespace DiffPlex
{
#if ENABLE_CLOTH
#endif

#if ENABLE_CLOUD_PROJECT_ID
#endif
    
    
    public class AloksTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
                                /// this is the property for ![Enfield image](Enfiled_5c7e2d1851c5cf115852cded.jpg)
                                /// </summary>
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

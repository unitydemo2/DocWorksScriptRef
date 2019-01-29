using System;

namespace DiffPlex
{
    
    [Obsolete]
    public class AloksTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        ///     <summary>
                ///     this is the property for 
                ///     </summary>
                        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        
        public string CompareString(string oldText, string newText, bool ignoreWhitespace)
        {
            if (oldText.Equals(newText))
                return "strings are equal";
            else
                return "not equal";
        }

        /// <!-- Badly formed XML comment ignored for member "M:DiffPlex.AloksTest.CompareStringLength(System.String,System.String,System.Boolean,System.Boolean)" -->
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

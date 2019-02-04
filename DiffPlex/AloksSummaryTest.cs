using System;

namespace DiffPlex
{
    [Obsolete]
    public class AloksSummaryTest
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
        /// this is the property for 
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
        /// <param name="oldText">this param is for existing text</param>
        /// <param name="newText">this param is for updated text</param>
        /// <param name="ignoreWhitespace"></param>
        /// <param name="ignoreCase"></param>
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
        /// <param name="oldText">Old text description</param>
        /// <param name="newText">new text description</param>
        /// <param name="ignoreWhitespace">Should ignore blank space or not</param>
        /// <returns>
        /// Method returns a string
        /// </returns>
        public string CreateSomeOutput(string oldText, string newText, bool ignoreWhitespace)
        {
            return "Test Output";
        }
    }
}

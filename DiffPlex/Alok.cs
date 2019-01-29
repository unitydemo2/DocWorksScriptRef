using System;
using System.Collections.Generic;
using DiffPlex.Model;

namespace DiffPlex
{
    [Obsolete]
    public class Differ : IDiffer
    {
        private static readonly string[] emptyStringArray = new string[0];
        /// <summary>
        /// this is the property for 
        /// </summary>
        [Obsolete]
        public string obsoletedPropertyForTesting { get; set; }

        public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace)
        {
            return CreateLineDiffs(oldText, newText, ignoreWhitespace, false);
        }

        /// <summary>
        /// this method is to find diffs in 2 texts
        /// </summary>
        /// <param name="oldText">this param is for existing text</param>
        /// <param name="newText">this param is for updated text</param>
        /// <param name="ignoreWhitespace"></param>
        /// <param name="ignoreCase"></param>
        /// <returns>
        /// <summary>
        /// this method returns result of both text
        /// </summary>
        /// </returns>
        [Obsolete]
        public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase)
        {
            if (oldText == null) throw new ArgumentNullException(nameof(oldText));
            if (newText == null) throw new ArgumentNullException(nameof(newText));
            return CreateCustomDiffs(oldText, newText, ignoreWhitespace, ignoreCase, str => str.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None));
        }

        public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace)
        {
            return CreateCharacterDiffs(oldText, newText, ignoreWhitespace, false);
        }
       }

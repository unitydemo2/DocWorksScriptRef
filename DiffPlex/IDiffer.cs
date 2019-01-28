using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                                                                /// Provides methods for generate differences between texts
                                                                /// </summary>
                                                                /// <description>
                                                                /// </description>
                                                                                                                            public interface IDiffer
    {
        
        
        /// <summary>
                /// scriptref
                /// </summary>
                /// <description>
                /// ![Main.WMR](WMR_5c387be7ed64cc1190cbfb52.jpg)
                /// </description>
                        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        /// <summary>
                /// </summary>
                /// <description>
                /// </description>
                        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        /// <summary>
                /// </summary>
                /// <description>
                /// </description>
                        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        /// <summary>
                /// </summary>
                /// <description>
                /// </description>
                        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        /// <summary>
                /// wrrrrrrrrrrrr
                /// </summary>
                /// <description>
                /// </description>
                        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        /// <summary>
                /// </summary>
                /// <description>
                /// </description>
                        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}
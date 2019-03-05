using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts
                /// </summary>
                /// <description>
                /// ![](test32_5c7e2059eed1782094fda55a.jpeg)
                /// </description>
                            public interface IDiffer
    {
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}
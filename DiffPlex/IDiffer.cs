using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                                                                /// Provides methods for generate differences between texts
                                                                /// </summary>
                                                                /// <description>
                                                                /// ![](angeler_5c6795831b16f52820f887aa.jpeg)<br/> <br/> <br/> <br/>  []()
                                                                /// </description>
                                                                                                                            public interface IDiffer
    {
        
        /// <summary>
                                /// [5c679f581b16f52820f89164](adding_5c679f581b16f52820f89164.cs)<br/> <br/>  Testing 123
                                /// </summary>
                                /// <description>
                                /// This is sample description
                                /// </description>
                                /// <returns>
                                /// Testing for pull and push 1233
                                /// </returns>
                                                        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        /// <summary>
                /// This is another description
                /// </summary>
                        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}
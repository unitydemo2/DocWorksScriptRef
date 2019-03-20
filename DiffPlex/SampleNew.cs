using System;
using System.Collections.Generic;
using DiffPlex.Model;

namespace DiffPlex
{
    
    /// <summary>
    /// Test summary
    /// </summary>
    public class SampleNew
    {
       
        
        public string PropertyForTesting { get; set; }

        
        
        public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace)
        {
            return CreateLineDiffs(oldText, newText, ignoreWhitespace, false);
        }
    }
}

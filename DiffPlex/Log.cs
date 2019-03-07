using System.Collections.Generic;
using System.Diagnostics;

namespace DiffPlex
{
    
    /// <summary>
    /// Push operation with codeblock
    /// </summary>
    /// <description>
    /// [5c7f6e20eed1782094fe94e3](delegatecode_5c7f6e20eed1782094fe94e3.cs)<br/> <br/>  Testing 168
    /// </description>
    public static class Log
    {
        
        
        [Conditional("LOG")]
        public static void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(string.Format(format, args));
        }

        
        
        [Conditional("LOG")]
        public static void Write(string format, params object[] args)
        {
            // not implemented
        }

        
        
        public static List<string> NumberList()
        {
            return new List<string>() { "1", "2", "3" };
        }

        
        public delegate int TestDelegate(string s);

        
        public delegate void CalculateSquare(double number);
    }
}
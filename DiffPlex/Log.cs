using System.Collections.Generic;
using System.Diagnostics;

namespace DiffPlex
{
    
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
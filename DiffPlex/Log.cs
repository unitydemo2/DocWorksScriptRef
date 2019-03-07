using System.Collections.Generic;
using System.Diagnostics;

namespace DiffPlex
{
    
    /// <description>
        /// ![](The-power-of-unity_5c74fb73bf9f0a0194bb1e0d.png)
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

        
        /// <summary>
                /// Tesing pull operation688790
                /// </summary>
                        public static List<string> NumberList()
        {
            return new List<string>() { "1", "2", "3" };
        }

        
        public delegate int TestDelegate(string s);

        
        public delegate void CalculateSquare(double number);
    }
}
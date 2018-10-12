using System.Diagnostics;

namespace DiffPlex
{
    /// <summary>
    ///This is to test pull operation12-10-2018
    /// </summary>

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

        
        
        public delegate int TestDelegate(string s);

        
        
        public delegate void CalculateSquare(double number);
    }
}

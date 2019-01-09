using System.Diagnostics;

namespace DiffPlex
{
    public static class intel
    {
        [Conditional("LOG")]
        public static void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(string.Format(format, args));
        }

        [Conditional("LOG")]
        public static string Write(string format, params object[] args)
        {
            // not implemented update content in script ref project
        }

        public delegate int TestDelegate(string s);

        public delegate void CalculateSquare(double number);
    }
}

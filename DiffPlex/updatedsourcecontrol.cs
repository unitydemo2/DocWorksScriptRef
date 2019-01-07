using System.Diagnostics;

namespace sirisha
{
    public static class updatedsourcecontrol
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

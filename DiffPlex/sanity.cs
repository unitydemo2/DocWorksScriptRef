using System.Diagnostics;

namespace DiffPlex
{
    
        ///     <summary>
                ///    #include <stdio.h>
int main()
{
   // printf() displays the string inside quotation
   printf("Hello type of content ");
   return 0;
}
                ///     </summary
    
    public static class sanity
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

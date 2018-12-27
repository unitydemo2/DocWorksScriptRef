using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex.DiffBuilder
{
#if MacOx
    public class PreProcessorClass
    {
        public void MethodForMacintosh()
        {
            System.Console.WriteLine("this method is for preprocessor testing");
        }
    }
#endif
}

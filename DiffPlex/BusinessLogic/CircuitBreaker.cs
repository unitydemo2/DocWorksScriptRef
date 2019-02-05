using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex.BusinessLogic
{
    public class CircuitBreaker : ICircuitBreaker
    {
        public bool IsBroken()
        {
            return true;
        }
    }
}

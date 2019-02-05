using System;
using System.Collections.Generic;
using System.Text;

namespace DiffPlex.BusinessLogic
{
    public interface ICircuitBreaker
    {
        bool IsBroken();
    }
}

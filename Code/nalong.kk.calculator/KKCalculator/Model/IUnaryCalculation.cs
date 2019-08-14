using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKCalculator
{
    public interface IUnaryCalculation
    {
        string GetResult(string number);
    }
}
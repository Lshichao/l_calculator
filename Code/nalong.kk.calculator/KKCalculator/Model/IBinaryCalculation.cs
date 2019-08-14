using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKCalculator
{
    public interface IBinaryCalculation
    {
        string GetResult(string leftValue, string rightValue);
    }
}
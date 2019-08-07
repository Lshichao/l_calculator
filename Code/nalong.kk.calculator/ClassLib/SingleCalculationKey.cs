using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class SingleCalculationKey : CalculationKey
    {
        public double Number
        {
            get => default(int);
            set
            {
            }
        }

        public override double GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
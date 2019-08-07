using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class DoubleCalculationKey : CalculationKey
    {
        public double Number1
        {
            get => default(int);
            set
            {
            }
        }

        public double Number2
        {
            get => default(int);
            set
            {
            }
        }
        public override double GetResult() {
            throw new NotImplementedException();
        }


    }
}
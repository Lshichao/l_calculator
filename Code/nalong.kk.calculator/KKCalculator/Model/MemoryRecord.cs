using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKCalculator
{
    public class MemoryRecord
    {
        public string Result
        {
            get;
            set;
        }


        public MemoryRecord(string result)
        {
            this.Result = result;
        }


        public bool Plus(string number)
        {
            throw new System.NotImplementedException();
        }

        public bool Minus(string number)
        {
            throw new System.NotImplementedException();
        }
    }
}
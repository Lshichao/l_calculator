using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class MemoryRecord
    {
        public double number
        {
            get => default(int);
            set
            {
            }
        }

        public MemoryPlusKey mPlusKey
        {
            get;
            set;
        }

        public MemoryReduceKey mReduceKey
        {
            get;
            set;
        }
    }
}
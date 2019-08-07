using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class Calculator
    {
        private Key[] keys;
        private double currentNumber;
        private Record currentRecord;
        private History history;
        private Memory memory;

        public Memory Memory
        {
            get => default(Memory);
            set
            {
            }
        }

        public History History
        {
            get => default(History);
            set
            {
            }
        }

        public Key Key
        {
            get => default(Key);
            set
            {
            }
        }

        public void DealWithKey(Key inputKey)
        {
            throw new System.NotImplementedException();
        }
    }
}
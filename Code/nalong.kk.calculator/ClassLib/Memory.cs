using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class Memory
    {
        private List<MemoryRecord> records;

        public MemoryRecord MemoryRecord
        {
            get => default(MemoryRecord);
            set
            {
            }
        }

        /// <summary>
        /// MS键
        /// </summary>
        public void AddRecord(MemoryRecord record)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// M+键
        /// </summary>
        public double CreaseMemory(double number)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// M-键
        /// </summary>
        public double IncreaseMemory(double number)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// MR键
        /// </summary>
        public MemoryRecord GetRecord(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// MC键
        /// </summary>
        public void ClearMemory()
        {
            throw new System.NotImplementedException();
        }
    }
}
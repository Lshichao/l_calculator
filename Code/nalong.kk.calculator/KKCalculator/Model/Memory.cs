using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace KKCalculator
{
    public class Memory:CollectionBase
    {

        //将集合类设置为可索引
        //public MemoryRecord this[int index]
        //{
        //    set => List[index] = value;
        //    get => (MemoryRecord)List[index];
        //}

        #region Method

        public void AddRecord(string neededStoreNumber)
        {
            
            MemoryRecord record = new MemoryRecord(neededStoreNumber);
            List.Insert(0, record);
        }

        public string GetRecord(int index)
        {
            MemoryRecord record = (MemoryRecord)List[index];
            return record.Result;
        }

        /// <summary></summary>
        public void ClearMemory()
        {
            List.Clear();
        }

        public void DeleteRecord(int index)
        {
            List.RemoveAt(index);
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace KKCalculator
{
    public class Historys:CollectionBase
    {
        //private List<HistoryRecord> records=new List<HistoryReord>();

        public void AddHistory(HistoryRecord record)
        {
            List.Insert(0, record);
        }

        public void DeleteRecord(int index)
        {
            List.RemoveAt(index);
        }

        public HistoryRecord GetRecord(int index)
        {
            return (HistoryRecord)List[index];
        }

        public void ClearHistorys()
        {
            List.Clear();
        }
    }
}
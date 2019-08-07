using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLib
{
    public class History
    {
        private List<Record> records;

        public Record Record
        {
            get => default(Record);
            set
            {
            }
        }

        public void Add(Record record)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new System.NotImplementedException();
        }

        public Record GetRecord(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}
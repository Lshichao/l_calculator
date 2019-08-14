using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKCalculator
{
    public class HistoryRecord
    {

        public HistoryRecord(string number,string expression)
        {
            this.Number = number;
            this.Expression = expression;
        }

        public string Number
        {
            get;
            set;
        }

        public string Expression
        {
            get;
            set;
        }
    }
}
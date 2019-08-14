using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace KKCalculator
{
    class Test:INotifyPropertyChanged
    {
        private string str;
        public Test()
        {
            str = "";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public string Str
        {
            get { return str; }
            set { str = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Str"));
            }
        }
    }
}

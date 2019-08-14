using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KKCalculator;
using System.ComponentModel;
using System.Windows.Input;

namespace KKCalculator
{
    public class Calculator:INotifyPropertyChanged
    {
        #region Field
        private string _displayNumber;
        private string _displayExpression;
        private UpdateDisplayCommand updateDisplayCommand;
        #endregion

        #region Mothod
        public Calculator()
        {
        }
        #endregion

        #region Attributes
        public string DisplayNumber
        {
            get { return _displayNumber; }
            set
            {
                _displayNumber = value;
                OnPropertyChanged("DisplayNumber");
            }
        }

        public string DisplayExpression
        {
            get { return _displayExpression; }
            set
            {
                _displayExpression = value;
                OnPropertyChanged("DisplayExpression");
            }
        }


        #endregion

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Command

        public ICommand UpdateDisplayCommand
        {
            get { return new UpdateDisplayCommand(UpdateDisplayCommand_execute); }
        }

        public void UpdateDisplayCommand_execute(string command)
        {
            if (command.Equals("Number1"))
            DisplayNumber += '1';
            if (command.Equals("Number2"))
            DisplayNumber += '2';
        }

        public bool UpdateDisplayCommand_canExecute()
        {
            return true;
        }
        #endregion
    }
}
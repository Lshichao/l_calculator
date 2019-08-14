using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKCalculator
{
    public class Control
    {
        #region Field
        private int flag;
        #endregion

        #region Attribution

        public string LeftValue
        {
            get;set;
        }

        public string RightValue
        {
            get; set;
        }

        public string Expression
        {
            get; set;
        }

        public string Operation
        {
            get; set;
        }

        public Historys Historys
        {
            get; set;
        }

        public Memory Memorys
        {
            get; set;
        }
        #endregion

        #region Method

        public Control()
        {
            Historys = new Historys();
            Memorys = new Memory();
        }

        public void Judge(string input)
        {
            //输入数字键
            if(input.Length==1 && 9>=input[0]-'0'&& input[0] - '0' >= 0)
            {

            }

            //输入backspace键
            if(input.Equals("X"))
            {

            }

            //输入CE键
            if (input.Equals("C"))
            {

            }
        }
        #endregion
    }
}
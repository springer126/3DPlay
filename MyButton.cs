using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace ButtonTest
{
    class MyButton : Button
    {
        public MyButton()
        {
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}

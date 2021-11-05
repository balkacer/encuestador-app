using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Utilities
{
    class Utility
    {
        public static void CloseOneOpenOne(Form close, Form open)
        {
            close.Hide();
            open.FormClosed += (s, args) => close.Close();
            open.Show();
        }
    }
}

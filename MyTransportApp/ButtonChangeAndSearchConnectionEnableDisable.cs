using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public static class ButtonChangeAndSearchConnectionEnableDisable
    {
        public static void ButtonEnableDisableChangeSearchConn(string textStart, string textZiel, Button buttonChange, Button buttonSearchConn)
        {
            if (!string.IsNullOrEmpty(textStart) || !string.IsNullOrEmpty(textZiel))
            {
                buttonChange.Enabled = true;
            }
            else
            {
                buttonChange.Enabled = false;
            }

            if (string.IsNullOrEmpty(textStart) || string.IsNullOrEmpty(textZiel))
            {
                buttonSearchConn.Enabled = false;
            }
            else
            {
                buttonSearchConn.Enabled = true;
            }
        }
    }

}

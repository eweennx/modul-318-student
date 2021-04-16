using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public static class ButtonEnableDisableSearchTable
    {
        public static void ButtonEnableDisableTable (string textStation, Button buttonTable)
        {
            if (string.IsNullOrEmpty(textStation))
            {
                buttonTable.Enabled = false;
            }
            else
            {
                buttonTable.Enabled = true;
            }
        }
    }
}

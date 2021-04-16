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

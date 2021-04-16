using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public static class SelectVorschlag
    {
        public static void SelectVorschlagToTextBox (TextBox textOrt, ListBox listboxVorschlaege)
        {
            textOrt.Text = listboxVorschlaege.SelectedItem.ToString();
        }
    }
}

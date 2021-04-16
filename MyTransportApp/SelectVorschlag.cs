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

using System.Windows.Forms;

namespace MyTransportApp
{
   public static class DataGridViewClear
    {
        public static void DataGridViewClearAndRefresh (DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }
    }
}

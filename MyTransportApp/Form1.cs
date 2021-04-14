using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;
using SwissTransport;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelZeit.Text = DateTime.Now.ToString("HH:mm");
        }

        private void comboBoxStartOrtVerbindung_SelectedIndexChanged(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
         
            if (comboBoxStartOrtVerbindung.Text.Length >= 3)
            {
                comboBoxStartOrtVerbindung.DroppedDown = true;
                Cursor.Current = Cursors.Default;
                foreach (Station station in transport.GetStations(Text).StationList)
                {
                    if (station.Name != null && station.Id != null)
                    {
                        comboBoxStartOrtVerbindung.Items.Add(station.Name);
                    }
                }
            }
        }
    } 
}
       



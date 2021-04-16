using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public static class Vorschlaege
    {
        public static void VorschlaegeFunction(string text, ListBox listBox, bool internet)
        {
            ITransport transport = new Transport();
            try
            {
                //anzeigen von vorschlägen
                listBox.Items.Clear();
                List<Station> stationenStart = transport.GetStations(text + "*").StationList;

                foreach (Station station in stationenStart)
                {
                    listBox.Items.Add(station.Name);
                }
            }

            catch
            {
                if (internet == true)
                {
                    MessageBox.Show("Ungültige Eingabe");
                }
                else
                {
                    MessageBox.Show("Überprüfe deine Internet Verbindung!");
                }


            } 
        }
    }      
}

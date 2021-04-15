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

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void timerUhr_Tick(object sender, EventArgs e)
        {
            labelZeit.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void textBoxStart_TextChanged_1(object sender, EventArgs e)
          {
            //anzeigen von vorschlägen
            listBoxStartVorschlaege.Items.Clear();
            Stations Vorschlag = transport.GetStations(textBoxStart.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                listBoxStartVorschlaege.Items.Add(station.Name);
            }
          }

        private void textBoxZielStation_TextChanged_1(object sender, EventArgs e)
        {
            //anzeigen von vorschlägen
            listBoxZielVorschlaege.Items.Clear();
            Stations Vorschlag = transport.GetStations(textBoxZielStation.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                listBoxZielVorschlaege.Items.Add(station.Name);
            }
        }

        public void Verbindungen(string from, string to)
        {
           
                
                 for (int i = 0; i < 4; i++)
                 {
                     //Dauer Trimmen, das nicht 00d oder 00h steht
                     string VerbindungDauer = transport.GetConnections(from, to).ConnectionList[i].Duration.ToString();
                     string result = VerbindungDauer.TrimStart(" 1234567890d".ToCharArray());
                     string result2 = result.Trim(":".ToCharArray());

                    dataGridViewVerbindungen.Rows.Add(new[]
                    {
                         transport.GetConnections(from, to).ConnectionList[i].From.Platform,
                         transport.GetConnections(from, to).ConnectionList[i].From.Departure.ToString(),
                         transport.GetConnections(from, to).ConnectionList[i].From.Station.Name,
                         transport.GetConnections(from, to).ConnectionList[i].To.Station.Name,
                         result2
                    }); ; ;
                 }
        }

        private void buttonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            Verbindungen(textBoxStart.Text, textBoxZielStation.Text);
        }

        private void listBoxStartVorschlaege_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxStart.Text = Convert.ToString(listBoxStartVorschlaege.SelectedItem);
        }

        private void listBoxZielVorschlaege_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxZielStation.Text = Convert.ToString(listBoxZielVorschlaege.SelectedItem);
        }

        
    }
 } 
       



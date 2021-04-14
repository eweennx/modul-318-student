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
            labelZeit.Text = DateTime.Now.ToString("HH:mm");
            
        }



        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {
            //anzeigen von vorschlägen
            listBoxStartVorschlaege.Items.Clear();
            Stations Vorschlag = transport.GetStations(textBoxStart.Text);

            foreach (Station station in Vorschlag.StationList)
            {
                listBoxStartVorschlaege.Items.Add(station.Name);
            }
        }


        private void textBoxZielStation_TextChanged(object sender, EventArgs e)
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
                //Bis letztes Ergebniss kommt
                 for (int i = 0; i < 10; i++)
                  {
                        dataGridViewVerbindungen.Rows.Add(new[]
                        {
                            transport.GetConnections(from, to).ConnectionList[i].From.Platform,  
                            transport.GetConnections(from, to).ConnectionList[i].From.Departure.ToString(),     
                            transport.GetConnections(from, to).ConnectionList[i].From.Station.Name,             
                            transport.GetConnections(from, to).ConnectionList[i].To.Station.Name,
                            transport.GetConnections(from, to).ConnectionList[i].From.Arrival.ToString(),
                            transport.GetConnections(from, to).ConnectionList[i].Duration                     
                        } );
                  }
        }

        private void buttonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            var conections = transport.GetConnections(textBoxZielStation.Text, textBoxStart.Text);
            for (int i = 0; i < 4; i++)
            {
                dataGridViewVerbindungen.Rows.Add(new string[]
                {
                    conections.ConnectionList[i].From.Platform.ToString(),
                    conections.ConnectionList[i].From.Departure.ToString(),
                    conections.ConnectionList[i].To.Arrival.ToString(),
                    conections.ConnectionList[i].To.Delay.ToString(),
                    conections.ConnectionList[i].Duration.ToString(),
                });
            }
        }
    }
 } 
       



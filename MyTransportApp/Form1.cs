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
using System.Net.Mail;
using System.Diagnostics;

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
            try
            {
                //anzeigen von vorschlägen
                listBoxStartVorschlaege.Items.Clear();
                List<Station> stationenStart = transport.GetStations(textBoxStart.Text + "*").StationList;

                foreach (Station station in stationenStart)
                {
                    listBoxStartVorschlaege.Items.Add(station.Name);
                }
            }
            catch
            {

            }   
         }

        private void textBoxZielStation_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //anzeigen von vorschlägen
                listBoxZielVorschlaege.Items.Clear();
                List<Station> stationenZiel = transport.GetStations(textBoxZielStation.Text + "*").StationList;

                foreach (Station station in stationenZiel)
                {
                    listBoxZielVorschlaege.Items.Add(station.Name);
                }
            }
            catch
            {

            }
        }

        private void buttonChangeStation_Click(object sender, EventArgs e)
        {
            try
            {
            string StartStation = textBoxStart.Text;
            string ZielStation = textBoxZielStation.Text;
            textBoxStart.Text = ZielStation;
            textBoxZielStation.Text = StartStation;
            }
            catch
            {

            }
        }

        public void Verbindungen(string from, string to, string date, string time)
        {
            
            List <Connection> VerbindungenSuchen = transport.GetConnections(from, to, date, time).ConnectionList;
                 
            for (int i = 0; i < 4; i++)
                 {
                //Dauer Trimmen, das nicht 00d oder 00h steht
                string VerbindungDauer = transport.GetConnections(from, to, date,time).ConnectionList[i].Duration.ToString();
                
                        string resultVerbindungsDauer = VerbindungDauer.TrimStart(" 0d".ToCharArray());
                        string resultVerbindungsDauer2 = resultVerbindungsDauer.Trim(":".ToCharArray());

                
                        dataGridViewVerbindungen.Rows.Add(new[]
                        {
                              VerbindungenSuchen[i].From.Platform,
                              VerbindungenSuchen[i].From.Departure?.ToString("HH:mm") ?? "unbekannt",
                              VerbindungenSuchen[i].From.Station.Name,
                              VerbindungenSuchen[i].To.Station.Name,
                              resultVerbindungsDauer2
                        }); ; ;
                
            }
                    
                     
        }

        private void buttonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            try
            {
            dataGridViewVerbindungen.Rows.Clear();
            dataGridViewVerbindungen.Refresh();
            Verbindungen(textBoxStart.Text, textBoxZielStation.Text, datepicker.Value.ToString("yyyy-MM-dd"), timepicker.Value.ToString("HH:mm"));
            }
            catch
            {
                MessageBox.Show("Bitte gebe eine Start- und Ziel-Station ein!");
            }
        }

        private void listBoxStartVorschlaege_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            textBoxStart.Text = Convert.ToString(listBoxStartVorschlaege.SelectedItem);
        }

        private void listBoxZielVorschlaege_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            textBoxZielStation.Text = Convert.ToString(listBoxZielVorschlaege.SelectedItem);
        }

        private void textBoxStation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxStationVorschlaege.Items.Clear();
                List<Station> stationenStation = transport.GetStations(textBoxStation.Text + "*").StationList;

                foreach (Station station in stationenStation)
                {
                    listBoxStationVorschlaege.Items.Add(station.Name);
                }
            }

            catch
            {

            }

        }
  
        private void listBoxStationVorschlaege_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxStation.Text = listBoxStationVorschlaege.SelectedItem.ToString();
        }

        private string timetabelId(string station)
        {
            return transport.GetStations(station).StationList[0].Id.ToString();
        }

        private void buttonAbfahrtstafelSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewAbfahrtstafel.Rows.Clear();
                dataGridViewAbfahrtstafel.Refresh();
                List<StationBoard> AbfahrtsBoard = transport.GetStationBoard(textBoxStation.Text, timetabelId(textBoxStation.Text)).Entries;

                for (int i = 0; i < 10; i++)
                {
                    dataGridViewAbfahrtstafel.Rows.Add(new string[]
                    {
                   AbfahrtsBoard[i].Stop.Departure.ToString("HH:mm") ?? "unbekannt",
                   AbfahrtsBoard[i].Number.ToString(),
                   AbfahrtsBoard[i].To.ToString()
                    });
                    ;
                }
                
            }

            catch
            {
                MessageBox.Show("Geht nicht !");
            }

        }

        private void buttonSendMail_Click (object sender, EventArgs e)
        {
            var MailMessage = new MailMessage();
            {
                MailMessage.Subject = "ÖV Verbindungen von " + this.textBoxStart.Text + " nach " + this.textBoxZielStation.Text + "%0D%0A";
                MailMessage.IsBodyHtml = true;
     
                    for (int i = 0; i< this.dataGridViewVerbindungen.RowCount - 1; i++)
                    {
                    MailMessage.Body += "Gleis: " + this.dataGridViewVerbindungen.Rows[i].Cells[0].Value;
                    MailMessage.Body += "  //  Zeit: " + this.dataGridViewVerbindungen.Rows[i].Cells[1].Value;
                    MailMessage.Body += "  //  Dauer: " + this.dataGridViewVerbindungen.Rows[i].Cells[4].Value;
                    MailMessage.Body += "%0D%0A";
                    }
                Process.Start(@"mailto:?subject=" + MailMessage.Subject + MailMessage.Body);
            }
        }
    }
 } 
       



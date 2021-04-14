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
        ITransport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
            labelZeit.Text = DateTime.Now.ToString("HH:mm");
        }

       

        private void comboBoxStartOrtVerbindung_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            Verbindungen(comboBoxStartOrtVerbindung.Text, comboBoxZielOrtVerbindung.Text);
        }
    } 
}
       



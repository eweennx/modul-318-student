using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Core;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {  
            InitializeComponent();
            labelUhrzeit.Text = DateTime.Now.ToString("HH:mm");
        }

        
    }
}

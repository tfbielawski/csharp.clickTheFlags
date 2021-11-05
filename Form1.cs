using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickTheFlags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handlers to trigger text upon click
        private void finlandBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland!";
        }

        private void franceBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France!";
        }

        private void germanyFlag_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany!";
        }
    }
}

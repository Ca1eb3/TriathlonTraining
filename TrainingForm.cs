// Caleb Smith
// 09/05/2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriathlonTraining
{
    public partial class TrainingForm : Form
    {
        BikePowerZones powerZones = new BikePowerZones();
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           powerZones.BikeFtpPower = Convert.ToInt32(powerBikeFtp.Text);
           // testValues.Text = Convert.ToString(powerZones.ZonesArray());
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

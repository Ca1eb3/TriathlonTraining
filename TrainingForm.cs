// Caleb Smith
// 09/05/2022 test
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
        // Methods
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
        // Calculates bike zones after clicking the calculate button beneath FTP benchmark
        private void button1_Click(object sender, EventArgs e)
        {
            powerZones.BikeFtpPower = Convert.ToInt32(powerBikeFtp.Text);
            bikeZonesTextBox4.Text = Convert.ToString(powerZones.ZonesArray(0, 0));
            bikeZonesTextBox5.Text = Convert.ToString(powerZones.ZonesArray(1, 0));
            bikeZonesTextBox6.Text = Convert.ToString(powerZones.ZonesArray(2, 0));
            bikeZonesTextBox7.Text = Convert.ToString(powerZones.ZonesArray(0, 1));
            bikeZonesTextBox8.Text = Convert.ToString(powerZones.ZonesArray(1, 1));
            bikeZonesTextBox9.Text = Convert.ToString(powerZones.ZonesArray(2, 1));
            bikeZonesTextBox10.Text = Convert.ToString(powerZones.ZonesArray(0, 2));
            bikeZonesTextBox11.Text = Convert.ToString(powerZones.ZonesArray(1, 2));
            bikeZonesTextBox12.Text = Convert.ToString(powerZones.ZonesArray(2, 2));
            bikeZonesTextBox13.Text = Convert.ToString(powerZones.ZonesArray(0, 3));
            bikeZonesTextBox14.Text = Convert.ToString(powerZones.ZonesArray(1, 3));
            bikeZonesTextBox15.Text = Convert.ToString(powerZones.ZonesArray(2, 3));
            bikeZonesTextBox16.Text = Convert.ToString(powerZones.ZonesArray(0, 4));
            bikeZonesTextBox17.Text = Convert.ToString(powerZones.ZonesArray(1, 4));
            bikeZonesTextBox18.Text = Convert.ToString(powerZones.ZonesArray(2, 4));
            bikeZonesTextBox19.Text = Convert.ToString(powerZones.ZonesArray(0, 5));
            bikeZonesTextBox20.Text = Convert.ToString(powerZones.ZonesArray(1, 5));
            bikeZonesTextBox21.Text = Convert.ToString(powerZones.ZonesArray(2, 5));
            bikeZonesTextBox22.Text = Convert.ToString(powerZones.ZonesArray(0, 6));
            bikeZonesTextBox23.Text = Convert.ToString(powerZones.ZonesArray(1, 6));
            bikeZonesTextBox24.Text = Convert.ToString(powerZones.ZonesArray(2, 6));
            // testValues.Text = Convert.ToString(powerZones.ZonesArray());
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        { 

        }
        private void bikeZonesTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void RunningZonesTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }
        // Calculates run zones after clicking the calculate button beneath 3k benchmark
        private void button3_Click(object sender, EventArgs e)
        {
            RunPaceZones Zone3000 = new RunPaceZones(Convert.ToInt32(TimeMinutes3k.Value), Convert.ToInt32(TimeSeconds3k.Value), 3000);
            RunningZonesTextBox16.Text = Convert.ToString(Zone3000.DistanceMeasured);
            RunningZonesTextBox17.Text = Convert.ToString($"{Zone3000.RunMinutes}:{Zone3000.RunSeconds}");
            RunningZonesTextBox18.Text = Zone3000.PaceString(Zone3000.PaceLower());
            RunningZonesTextBox19.Text = Zone3000.PaceString(Zone3000.PaceActual());
            RunningZonesTextBox20.Text = Zone3000.PaceString(Zone3000.PaceUpper());
            int TotalSeconds3000 = TimeConverter.ConvertedToSeconds(Zone3000.RunHours, Zone3000.RunMinutes, Zone3000.RunSeconds);
            int Seconds800 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 800); // issue with RaceTimePredictor
            int[] Time800 = new int[2] { TimeConverter.ConvertedToTime(Seconds800, 1), TimeConverter.ConvertedToTime(Seconds800, 2) };
            RunPaceZones Zone800 = new RunPaceZones(Time800[0], Time800[1], 800);
            RunningZonesTextBox6.Text = Convert.ToString(Zone800.DistanceMeasured);
            RunningZonesTextBox7.Text = Convert.ToString($"{Zone800.RunMinutes}:{Zone800.RunSeconds}");
        }
    }
}

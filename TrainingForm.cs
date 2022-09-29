﻿// Caleb Smith
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
            BikePowerZones powerZones = new BikePowerZones();
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
            // Run Distance Pace Zones
            // 3000 Pace Zones
            RunDistancePaceZones Zone3000 = new RunDistancePaceZones(Convert.ToInt32(TimeMinutes3k.Value), Convert.ToInt32(TimeSeconds3k.Value), 3000);
            RunningZonesTextBox16.Text = Convert.ToString(Zone3000.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox17.Text = TimeConverter.DisplayTime(Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            // Dispays Pace
            RunningZonesTextBox18.Text = Zone3000.PaceString(Zone3000.PaceLower());
            RunningZonesTextBox19.Text = Zone3000.PaceString(Zone3000.PaceActual());
            RunningZonesTextBox20.Text = Zone3000.PaceString(Zone3000.PaceUpper());
            // 800 Pace Zones
            int TotalSeconds3000 = TimeConverter.ConvertedToSeconds(Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            int Seconds800 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 800);
            int[] Time800 = new int[2] { TimeConverter.ConvertedToTime(Seconds800, 1), TimeConverter.ConvertedToTime(Seconds800, 2) };
            RunDistancePaceZones Zone800 = new RunDistancePaceZones(Time800[0], Time800[1], 800);
            RunningZonesTextBox6.Text = Convert.ToString(Zone800.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox7.Text = TimeConverter.DisplayTime(Zone800.Hours, Zone800.Minutes, Zone800.Seconds);
            // Dispays Pace
            RunningZonesTextBox8.Text = Zone800.PaceString(Zone800.PaceLower());
            RunningZonesTextBox9.Text = Zone800.PaceString(Zone800.PaceActual());
            RunningZonesTextBox10.Text = Zone800.PaceString(Zone800.PaceUpper());
            // 1609/Mile Pace Zones
            int Seconds1609 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 1609);
            int[] Time1609 = new int[2] { TimeConverter.ConvertedToTime(Seconds1609, 1), TimeConverter.ConvertedToTime(Seconds1609, 2) };
            RunDistancePaceZones Zone1609 = new RunDistancePaceZones(Time1609[0], Time1609[1], 1609);
            RunningZonesTextBox11.Text = Convert.ToString(Zone1609.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox12.Text = TimeConverter.DisplayTime(Zone1609.Hours, Zone1609.Minutes, Zone1609.Seconds);
            // Dispays Pace
            RunningZonesTextBox13.Text = Zone1609.PaceString(Zone1609.PaceLower());
            RunningZonesTextBox14.Text = Zone1609.PaceString(Zone1609.PaceActual());
            RunningZonesTextBox15.Text = Zone1609.PaceString(Zone1609.PaceUpper());
            // 5000 Pace Zones
            int Seconds5000 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 5000);
            int[] Time5000 = new int[2] { TimeConverter.ConvertedToTime(Seconds5000, 1), TimeConverter.ConvertedToTime(Seconds5000, 2) };
            RunDistancePaceZones Zone5000 = new RunDistancePaceZones(Time5000[0], Time5000[1], 5000);
            RunningZonesTextBox21.Text = Convert.ToString(Zone5000.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox22.Text = TimeConverter.DisplayTime(Zone5000.Hours, Zone5000.Minutes, Zone5000.Seconds);
            // Dispays Pace
            RunningZonesTextBox23.Text = Zone5000.PaceString(Zone5000.PaceLower());
            RunningZonesTextBox24.Text = Zone5000.PaceString(Zone5000.PaceActual());
            RunningZonesTextBox25.Text = Zone5000.PaceString(Zone5000.PaceUpper());
            // 10000 Pace Zones
            int Seconds10000 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 10000);
            int[] Time10000 = new int[2] { TimeConverter.ConvertedToTime(Seconds10000, 1), TimeConverter.ConvertedToTime(Seconds10000, 2) };
            RunDistancePaceZones Zone10000 = new RunDistancePaceZones(Time10000[0], Time10000[1], 10000);
            RunningZonesTextBox26.Text = Convert.ToString(Zone10000.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox27.Text = TimeConverter.DisplayTime(Zone10000.Hours, Zone10000.Minutes, Zone10000.Seconds);
            // Dispays Pace
            RunningZonesTextBox28.Text = Zone10000.PaceString(Zone10000.PaceLower());
            RunningZonesTextBox29.Text = Zone10000.PaceString(Zone10000.PaceActual());
            RunningZonesTextBox30.Text = Zone10000.PaceString(Zone10000.PaceUpper());
            // 21097/Half-Marathon Pace Zones
            int Seconds21097 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 21097);
            int[] Time21097 = new int[3] { TimeConverter.ConvertedToTime(Seconds21097, 0), TimeConverter.ConvertedToTime(Seconds21097, 1), TimeConverter.ConvertedToTime(Seconds21097, 2) };
            RunDistancePaceZones Zone21097 = new RunDistancePaceZones(Time21097[0], Time21097[1], Time21097[2], 21097);
            RunningZonesTextBox31.Text = Convert.ToString(Zone21097.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox32.Text = TimeConverter.DisplayTime(Zone21097.Hours, Zone21097.Minutes, Zone21097.Seconds);
            // Dispays Pace
            RunningZonesTextBox33.Text = Zone21097.PaceString(Zone21097.PaceLower());
            RunningZonesTextBox34.Text = Zone21097.PaceString(Zone21097.PaceActual());
            RunningZonesTextBox35.Text = Zone21097.PaceString(Zone21097.PaceUpper());
            // 42195/Marathon Pace Zones
            int Seconds42195 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 42195);
            int[] Time42195 = new int[3] { TimeConverter.ConvertedToTime(Seconds42195, 0), TimeConverter.ConvertedToTime(Seconds42195, 1), TimeConverter.ConvertedToTime(Seconds42195, 2) };
            RunDistancePaceZones Zone42195 = new RunDistancePaceZones(Time42195[0], Time42195[1], Time42195[2], 42195);
            RunningZonesTextBox36.Text = Convert.ToString(Zone42195.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox37.Text = TimeConverter.DisplayTime(Zone42195.Hours, Zone42195.Minutes, Zone42195.Seconds);
            // Dispays Pace
            RunningZonesTextBox38.Text = Zone42195.PaceString(Zone42195.PaceLower());
            RunningZonesTextBox39.Text = Zone42195.PaceString(Zone42195.PaceActual());
            RunningZonesTextBox40.Text = Zone42195.PaceString(Zone42195.PaceUpper());

            // Run Threshold Pace Zones
            // T1 Zones
            RunThresholdPaceZones T1 = new RunThresholdPaceZones("T1-Detraining", 1.7, Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            RunThresholdTextBox5.Text = T1.ZoneName;
            RunThresholdTextBox6.Text = T1.PaceString(T1.PaceLower());
            RunThresholdTextBox7.Text = T1.PaceString(T1.PaceActual());
            RunThresholdTextBox8.Text = T1.PaceString(T1 .PaceUpper());
            // T2 Zones
            RunThresholdPaceZones T2 = new RunThresholdPaceZones("T2-Low Aerobic", 1.5, Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            RunThresholdTextBox9.Text = T2.ZoneName;
            RunThresholdTextBox10.Text = T2.PaceString(T2.PaceLower());
            RunThresholdTextBox11.Text = T2.PaceString(T2.PaceActual());
            RunThresholdTextBox12.Text = T2.PaceString(T2.PaceUpper());
            // T3 Zones
            RunThresholdPaceZones T3 = new RunThresholdPaceZones("T3-Mid Aerobic", 1.3, Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            RunThresholdTextBox13.Text = T3.ZoneName;
            RunThresholdTextBox14.Text = T3.PaceString(T3.PaceLower());
            RunThresholdTextBox15.Text = T3.PaceString(T3.PaceActual());
            RunThresholdTextBox16.Text = T3.PaceString(T3.PaceUpper());
            // T4 Zones
            RunThresholdPaceZones T4 = new RunThresholdPaceZones("T4-High Aerobic", Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            RunThresholdTextBox17.Text = T4.ZoneName;
            RunThresholdTextBox18.Text = T4.PaceString(Zone21097.PaceLower());
            RunThresholdTextBox19.Text = T4.PaceString((Zone21097.PaceLower() + Zone42195.PaceUpper())/2);
            RunThresholdTextBox20.Text = T4.PaceString(Zone42195.PaceUpper());
            // T5 Zones
            RunThresholdPaceZones T5 = new RunThresholdPaceZones("T5-Aerobic Threshold", Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            RunThresholdTextBox21.Text = T5.ZoneName;
            RunThresholdTextBox22.Text = T5.PaceString(Zone5000.PaceLower());
            RunThresholdTextBox23.Text = T5.PaceString((Zone10000.PaceUpper() + Zone5000.PaceLower()) / 2);
            RunThresholdTextBox24.Text = T5.PaceString(Zone10000.PaceUpper());
            // T6 Zones
            RunThresholdPaceZones T6 = new RunThresholdPaceZones("T6-Anaerobic Threshold", 1.125, Zone800.Hours, Zone800.Minutes, Zone800.Seconds);
            RunThresholdTextBox25.Text = T6.ZoneName;
            RunThresholdTextBox26.Text = T6.PaceString(T6.PaceLower() * 3);
            RunThresholdTextBox27.Text = T6.PaceString(T6.PaceActual() * 3);
            RunThresholdTextBox28.Text = T6.PaceString(T6.PaceUpper() * 3);
            // T7 Zones
            RunThresholdPaceZones T7 = new RunThresholdPaceZones("T7-Neuromuscular Threshold", 1, Zone800.Hours, Zone800.Minutes, Zone800.Seconds);
            RunThresholdTextBox29.Text = T7.ZoneName;
            RunThresholdTextBox30.Text = T7.PaceString(T7.PaceLower() * 3);
            RunThresholdTextBox31.Text = T7.PaceString(T7.PaceActual() * 3);
            RunThresholdTextBox32.Text = T7.PaceString(T7.PaceUpper() * 3);
        }

        private void ftpPower_Click(object sender, EventArgs e)
        {

        }
        // Calculates swim zones after clicking the calculate button beneath 500yd benchmark
        private void button2_Click(object sender, EventArgs e)
        {
            // 500 yard zone
            SwimPaceZones SwimZone500 = new SwimPaceZones(Convert.ToInt32(TimeMinutes500.Value), Convert.ToInt32(TimeSeconds500.Value), 500);

        }
    }
}

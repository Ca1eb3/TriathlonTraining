// Caleb Smith
// 09/05/2022
using System;
using System.Windows.Forms;
using TriathlonTraining.CalculationTools;
using TriathlonTraining.BenchmarkData;

namespace TriathlonTraining
{
    public partial class BenchmarkTests : Form
    {
        // Methods
        public BenchmarkTests()
        {
            InitializeComponent();
        }
        // Calculates bike zones after clicking the calculate button beneath FTP benchmark
        private void BikeCalculateButtonClick(object sender, EventArgs e)
        {
            BikePowerZones powerZones = new BikePowerZones
            {
                BikeFtpPower = Convert.ToInt32(powerBikeFtp.Text)
            };
            powerZones.SetZonesArray();
            bikeZonesTextBox4.Text = Convert.ToString(powerZones.PowerZones[0]);
            bikeZonesTextBox5.Text = Convert.ToString(powerZones.PowerZones[1]);
            bikeZonesTextBox6.Text = Convert.ToString(powerZones.PowerZones[2]);
            bikeZonesTextBox7.Text = Convert.ToString(powerZones.PowerZones[3]);
            bikeZonesTextBox8.Text = Convert.ToString(powerZones.PowerZones[4]);
            bikeZonesTextBox9.Text = Convert.ToString(powerZones.PowerZones[5]);
            bikeZonesTextBox10.Text = Convert.ToString(powerZones.PowerZones[6]);
            bikeZonesTextBox11.Text = Convert.ToString(powerZones.PowerZones[7]);
            bikeZonesTextBox12.Text = Convert.ToString(powerZones.PowerZones[8]);
            bikeZonesTextBox13.Text = Convert.ToString(powerZones.PowerZones[9]);
            bikeZonesTextBox14.Text = Convert.ToString(powerZones.PowerZones[10]);
            bikeZonesTextBox15.Text = Convert.ToString(powerZones.PowerZones[11]);
            bikeZonesTextBox16.Text = Convert.ToString(powerZones.PowerZones[12]);
            bikeZonesTextBox17.Text = Convert.ToString(powerZones.PowerZones[13]);
            bikeZonesTextBox18.Text = Convert.ToString(powerZones.PowerZones[14]);
            bikeZonesTextBox19.Text = Convert.ToString(powerZones.PowerZones[15]);
            bikeZonesTextBox20.Text = Convert.ToString(powerZones.PowerZones[16]);
            bikeZonesTextBox21.Text = Convert.ToString(powerZones.PowerZones[17]);
            bikeZonesTextBox22.Text = Convert.ToString(powerZones.PowerZones[18]);
            bikeZonesTextBox23.Text = Convert.ToString(powerZones.PowerZones[19]);
            bikeZonesTextBox24.Text = Convert.ToString(powerZones.PowerZones[20]);
        }
        // Calculates run zones after clicking the calculate button beneath 3k benchmark
        private void RunCalculateButtonClick(object sender, EventArgs e)
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
            // used for calculating other pace zones
            int TotalSeconds3000 = TimeConverter.ConvertedToSeconds(Zone3000.Hours, Zone3000.Minutes, Zone3000.Seconds);
            // 800 Pace Zones
            int Seconds800 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 800);
            RunDistancePaceZones Zone800 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds800, 0), TimeConverter.ConvertedToTime(Seconds800, 1), TimeConverter.ConvertedToTime(Seconds800, 2), 800);
            RunningZonesTextBox6.Text = Convert.ToString(Zone800.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox7.Text = TimeConverter.DisplayTime(Zone800.Hours, Zone800.Minutes, Zone800.Seconds);
            // Dispays Pace
            RunningZonesTextBox8.Text = Zone800.PaceString(Zone800.PaceLower());
            RunningZonesTextBox9.Text = Zone800.PaceString(Zone800.PaceActual());
            RunningZonesTextBox10.Text = Zone800.PaceString(Zone800.PaceUpper());
            // 1609/Mile Pace Zones
            int Seconds1609 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 1609);
            RunDistancePaceZones Zone1609 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds1609, 0), TimeConverter.ConvertedToTime(Seconds1609, 1), TimeConverter.ConvertedToTime(Seconds1609, 2), 1609);
            RunningZonesTextBox11.Text = Convert.ToString(Zone1609.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox12.Text = TimeConverter.DisplayTime(Zone1609.Hours, Zone1609.Minutes, Zone1609.Seconds);
            // Dispays Pace
            RunningZonesTextBox13.Text = Zone1609.PaceString(Zone1609.PaceLower());
            RunningZonesTextBox14.Text = Zone1609.PaceString(Zone1609.PaceActual());
            RunningZonesTextBox15.Text = Zone1609.PaceString(Zone1609.PaceUpper());
            // 5000 Pace Zones
            int Seconds5000 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 5000);
            RunDistancePaceZones Zone5000 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds5000, 0), TimeConverter.ConvertedToTime(Seconds5000, 1), TimeConverter.ConvertedToTime(Seconds5000, 2), 5000);
            RunningZonesTextBox21.Text = Convert.ToString(Zone5000.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox22.Text = TimeConverter.DisplayTime(Zone5000.Hours, Zone5000.Minutes, Zone5000.Seconds);
            // Dispays Pace
            RunningZonesTextBox23.Text = Zone5000.PaceString(Zone5000.PaceLower());
            RunningZonesTextBox24.Text = Zone5000.PaceString(Zone5000.PaceActual());
            RunningZonesTextBox25.Text = Zone5000.PaceString(Zone5000.PaceUpper());
            // 10000 Pace Zones
            int Seconds10000 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 10000);
            RunDistancePaceZones Zone10000 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds10000, 0), TimeConverter.ConvertedToTime(Seconds10000, 1), TimeConverter.ConvertedToTime(Seconds10000, 2), 10000);
            RunningZonesTextBox26.Text = Convert.ToString(Zone10000.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox27.Text = TimeConverter.DisplayTime(Zone10000.Hours, Zone10000.Minutes, Zone10000.Seconds);
            // Dispays Pace
            RunningZonesTextBox28.Text = Zone10000.PaceString(Zone10000.PaceLower());
            RunningZonesTextBox29.Text = Zone10000.PaceString(Zone10000.PaceActual());
            RunningZonesTextBox30.Text = Zone10000.PaceString(Zone10000.PaceUpper());
            // 21097/Half-Marathon Pace Zones
            int Seconds21097 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 21097);
            RunDistancePaceZones Zone21097 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds21097, 0), TimeConverter.ConvertedToTime(Seconds21097, 1), TimeConverter.ConvertedToTime(Seconds21097, 2), 21097);
            RunningZonesTextBox31.Text = Convert.ToString(Zone21097.DistanceMeasured);
            // Displays Time
            RunningZonesTextBox32.Text = TimeConverter.DisplayTime(Zone21097.Hours, Zone21097.Minutes, Zone21097.Seconds);
            // Dispays Pace
            RunningZonesTextBox33.Text = Zone21097.PaceString(Zone21097.PaceLower());
            RunningZonesTextBox34.Text = Zone21097.PaceString(Zone21097.PaceActual());
            RunningZonesTextBox35.Text = Zone21097.PaceString(Zone21097.PaceUpper());
            // 42195/Marathon Pace Zones
            int Seconds42195 = RaceTimePredictor.PredictTime2(TotalSeconds3000, 3000, 42195);
            RunDistancePaceZones Zone42195 = new RunDistancePaceZones(TimeConverter.ConvertedToTime(Seconds42195, 0), TimeConverter.ConvertedToTime(Seconds42195, 1), TimeConverter.ConvertedToTime(Seconds42195, 2), 42195);
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
        // Calculates swim zones after clicking the calculate button beneath 500yd benchmark
        // Currently uses 1.15 as b factor to predict time 2
        private void SwimCalculateButtonClick(object sender, EventArgs e)
        {
            // 500 yard pace zones
            SwimPaceZones SwimZone500 = new SwimPaceZones(Convert.ToInt32(TimeMinutes500.Value), Convert.ToInt32(TimeSeconds500.Value), 500);
            SwimZonesTextBox21.Text = Convert.ToString(SwimZone500.DistanceMeasured);
            // Displays time
            SwimZonesTextBox22.Text = TimeConverter.DisplayTime(SwimZone500.Hours, SwimZone500.Minutes, SwimZone500.Seconds);
            // Displays pace
            SwimZonesTextBox23.Text = SwimZone500.PaceString(SwimZone500.PaceLower());
            SwimZonesTextBox24.Text = SwimZone500.PaceString(SwimZone500.PaceActual());
            SwimZonesTextBox25.Text = SwimZone500.PaceString(SwimZone500.PaceUpper());
            // used for calculating other pace zones
            int TotalSeconds500 = TimeConverter.ConvertedToSeconds(SwimZone500.Hours, SwimZone500.Minutes, SwimZone500.Seconds);
            // 50 yard pace zones
            int Seconds50 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 50, 1.15);
            SwimPaceZones SwimZone50 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds50, 0), TimeConverter.ConvertedToTime(Seconds50, 1), TimeConverter.ConvertedToTime(Seconds50, 2), 50);
            SwimZonesTextBox6.Text = Convert.ToString(SwimZone50.DistanceMeasured);
            // Displays time
            SwimZonesTextBox7.Text = TimeConverter.DisplayTime(SwimZone50.Hours, SwimZone50.Minutes, SwimZone50.Seconds);
            // Displays pace
            SwimZonesTextBox8.Text = SwimZone50.PaceString(SwimZone50.PaceLower());
            SwimZonesTextBox9.Text = SwimZone50.PaceString(SwimZone50.PaceActual());
            SwimZonesTextBox10.Text = SwimZone50.PaceString(SwimZone50.PaceUpper());
            // 100 yard pace zones
            int Seconds100 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 100, 1.15);
            SwimPaceZones SwimZone100 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds100, 0), TimeConverter.ConvertedToTime(Seconds100, 1), TimeConverter.ConvertedToTime(Seconds100, 2), 100);
            SwimZonesTextBox11.Text = Convert.ToString(SwimZone100.DistanceMeasured);
            // Displays time
            SwimZonesTextBox12.Text = TimeConverter.DisplayTime(SwimZone100.Hours, SwimZone100.Minutes, SwimZone100.Seconds);
            // Displays pace
            SwimZonesTextBox13.Text = SwimZone100.PaceString(SwimZone100.PaceLower());
            SwimZonesTextBox14.Text = SwimZone100.PaceString(SwimZone100.PaceActual());
            SwimZonesTextBox15.Text = SwimZone100.PaceString(SwimZone100.PaceUpper());
            // 200 yard pace zones
            int Seconds200 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 200, 1.15);
            SwimPaceZones SwimZone200 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds200, 0), TimeConverter.ConvertedToTime(Seconds200, 1), TimeConverter.ConvertedToTime(Seconds200, 2), 200);
            SwimZonesTextBox16.Text = Convert.ToString(SwimZone200.DistanceMeasured);
            // Displays time
            SwimZonesTextBox17.Text = TimeConverter.DisplayTime(SwimZone200.Hours, SwimZone200.Minutes, SwimZone200.Seconds);
            // Displays pace
            SwimZonesTextBox18.Text = SwimZone200.PaceString(SwimZone200.PaceLower());
            SwimZonesTextBox19.Text = SwimZone200.PaceString(SwimZone200.PaceActual());
            SwimZonesTextBox20.Text = SwimZone200.PaceString(SwimZone200.PaceUpper());
            // 1000 yard pace zones
            int Seconds1000 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 1000, 1.15);
            SwimPaceZones SwimZone1000 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds1000, 0), TimeConverter.ConvertedToTime(Seconds1000, 1), TimeConverter.ConvertedToTime(Seconds1000, 2), 1000);
            SwimZonesTextBox26.Text = Convert.ToString(SwimZone1000.DistanceMeasured);
            // Displays time
            SwimZonesTextBox27.Text = TimeConverter.DisplayTime(SwimZone1000.Hours, SwimZone1000.Minutes, SwimZone1000.Seconds);
            // Displays pace
            SwimZonesTextBox28.Text = SwimZone1000.PaceString(SwimZone1000.PaceLower());
            SwimZonesTextBox29.Text = SwimZone1000.PaceString(SwimZone1000.PaceActual());
            SwimZonesTextBox30.Text = SwimZone1000.PaceString(SwimZone1000.PaceUpper());
            // 1500 yard pace zones
            int Seconds1500 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 1500, 1.15);
            SwimPaceZones SwimZone1500 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds1500, 0), TimeConverter.ConvertedToTime(Seconds1500, 1), TimeConverter.ConvertedToTime(Seconds1500, 2), 1500);
            SwimZonesTextBox31.Text = Convert.ToString(SwimZone1500.DistanceMeasured);
            // Displays time
            SwimZonesTextBox32.Text = TimeConverter.DisplayTime(SwimZone1500.Hours, SwimZone1500.Minutes, SwimZone1500.Seconds);
            // Displays pace
            SwimZonesTextBox33.Text = SwimZone1500.PaceString(SwimZone1500.PaceLower());
            SwimZonesTextBox34.Text = SwimZone1500.PaceString(SwimZone1500.PaceActual());
            SwimZonesTextBox35.Text = SwimZone1500.PaceString(SwimZone1500.PaceUpper());
            // 1650 yard pace zones
            int Seconds1650 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 1650, 1.15);
            SwimPaceZones SwimZone1650 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds1650, 0), TimeConverter.ConvertedToTime(Seconds1650, 1), TimeConverter.ConvertedToTime(Seconds1650, 2), 1650);
            SwimZonesTextBox36.Text = Convert.ToString(SwimZone1650.DistanceMeasured);
            // Displays time
            SwimZonesTextBox37.Text = TimeConverter.DisplayTime(SwimZone1650.Hours, SwimZone1650.Minutes, SwimZone1650.Seconds);
            // Displays pace
            SwimZonesTextBox38.Text = SwimZone1650.PaceString(SwimZone1650.PaceLower());
            SwimZonesTextBox39.Text = SwimZone1650.PaceString(SwimZone1650.PaceActual());
            SwimZonesTextBox40.Text = SwimZone1650.PaceString(SwimZone1650.PaceUpper());
            // 3000 yard pace zones
            int Seconds3000 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 3000, 1.15);
            SwimPaceZones SwimZone3000 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds3000, 0), TimeConverter.ConvertedToTime(Seconds3000, 1), TimeConverter.ConvertedToTime(Seconds3000, 2), 3000);
            SwimZonesTextBox41.Text = Convert.ToString(SwimZone3000.DistanceMeasured);
            // Displays time
            SwimZonesTextBox42.Text = TimeConverter.DisplayTime(SwimZone3000.Hours, SwimZone3000.Minutes, SwimZone3000.Seconds);
            // Displays pace
            SwimZonesTextBox43.Text = SwimZone3000.PaceString(SwimZone3000.PaceLower());
            SwimZonesTextBox44.Text = SwimZone3000.PaceString(SwimZone3000.PaceActual());
            SwimZonesTextBox45.Text = SwimZone3000.PaceString(SwimZone3000.PaceUpper());
            // 5000 yard pace zones
            int Seconds5000 = RaceTimePredictor.PredictTime2Custom(TotalSeconds500, 500, 5000, 1.15);
            SwimPaceZones SwimZone5000 = new SwimPaceZones(TimeConverter.ConvertedToTime(Seconds5000, 0), TimeConverter.ConvertedToTime(Seconds5000, 1), TimeConverter.ConvertedToTime(Seconds5000, 2), 5000);
            SwimZonesTextBox46.Text = Convert.ToString(SwimZone5000.DistanceMeasured);
            // Displays time
            SwimZonesTextBox47.Text = TimeConverter.DisplayTime(SwimZone5000.Hours, SwimZone5000.Minutes, SwimZone5000.Seconds);
            // Displays pace
            SwimZonesTextBox48.Text = SwimZone5000.PaceString(SwimZone5000.PaceLower());
            SwimZonesTextBox49.Text = SwimZone5000.PaceString(SwimZone5000.PaceActual());
            SwimZonesTextBox50.Text = SwimZone5000.PaceString(SwimZone5000.PaceUpper());
        }
        // Calculate all values
        private void CalculateButton(object sender, EventArgs e)
        {
            BikeCalculateButton.PerformClick();
            SwimCalculateButton.PerformClick();
            RunCalculateButton.PerformClick();
        }
    }
}

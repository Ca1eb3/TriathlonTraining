// Caleb Smith
// 09/05/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining.BenchmarkData
{
    public class BikePowerZones
    {
        // Class Variables
        private int bikeFtpPower = 0;
        private double[] zoneNumber = new double[7];
        private int[] powerZones = new int[21];


        // Encapsulation
        public int BikeFtpPower
        {
            get { return bikeFtpPower; }
            set { bikeFtpPower = value; }
        }
        public double[] ZoneNumber
        {
            get 
            { 
                for (int z = 0; z < 7; z++)
                {
                    zoneNumber[z] = z + 1;
                }
                return zoneNumber;
            }
            set
            { 
                zoneNumber = value;
            }
        }
        public int[] PowerZones
        {
            get { return powerZones; }
            set { powerZones = value; }
        }

        // Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Bike FTP: " + BikeFtpPower + "\n";
            message = message + "ZoneNumber: " + ZoneNumber + "\n";
            return message;
        }
        public double LowerPowerZones(int ArrayIndex)
        {
            double[] LowerPower = new double[7];
            LowerPower[0] = 0;
            LowerPower[1] = BikeFtpPower * .56;
            LowerPower[2] = BikeFtpPower * .76;
            LowerPower[3] = BikeFtpPower * .91;
            LowerPower[4] = BikeFtpPower * 1.06;
            LowerPower[5] = BikeFtpPower * 1.21;
            LowerPower[6] = BikeFtpPower * 1.51;
            return LowerPower[ArrayIndex];
        }
        public double UpperPowerZones(int ArrayIndex)
        {
            double[] UpperPower = new double[7];
            UpperPower[0] = BikeFtpPower * .55;
            UpperPower[1] = BikeFtpPower * .75;
            UpperPower[2] = BikeFtpPower * .90;
            UpperPower[3] = BikeFtpPower * 1.05;
            UpperPower[4] = BikeFtpPower * 1.20;
            UpperPower[5] = BikeFtpPower * 1.50;
            UpperPower[6] = BikeFtpPower * 3;
            return UpperPower[ArrayIndex];
        }
        public void SetZonesArray()
        {
            for (int i = 0; i < PowerZones.Length; i++)
            {
                if (i % 3 == 0)
                {
                    PowerZones[i] = Convert.ToInt32(ZoneNumber[i / 3]);
                }
                else if (i % 3 == 1)
                {
                    PowerZones[i] = Convert.ToInt32(LowerPowerZones(i / 3));
                }
                else if (i % 3 == 2)
                {
                    PowerZones[i] = Convert.ToInt32(UpperPowerZones(i / 3));
                }
            }
        }
    }
}

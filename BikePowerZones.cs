// Caleb Smith
// 09/05/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    internal class BikePowerZones
    {
        // Class Variables
        private int bikeFtpPower = 0;
        private double[] zoneNumber = new double[7];


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

        // Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Bike FTP: " + BikeFtpPower + "\n";
            message = message + "ZoneNumber: " + ZoneNumber + "\n";
            return message;
        }
        public Array LowerPowerZones()
        {
            double[] LowerPower = new double[7];
            LowerPower[0] = 0;
            LowerPower[1] = BikeFtpPower * .56;
            LowerPower[2] = BikeFtpPower * .76;
            LowerPower[3] = BikeFtpPower * .91;
            LowerPower[4] = BikeFtpPower * 1.06;
            LowerPower[5] = BikeFtpPower * 1.21;
            LowerPower[6] = BikeFtpPower * 1.51;
            return LowerPower;
        }
        public Array UpperPowerZones()
        {
            double[] UpperPower = new double[7];
            UpperPower[0] = BikeFtpPower * .55;
            UpperPower[1] = BikeFtpPower * .75;
            UpperPower[2] = BikeFtpPower * .90;
            UpperPower[3] = BikeFtpPower * 1.05;
            UpperPower[4] = BikeFtpPower * 1.20;
            UpperPower[5] = BikeFtpPower * 1.50;
            UpperPower[6] = BikeFtpPower * 3;
            return UpperPower;
        }
        public Array ZonesArray()
        {
            Array[] PowerZoneData = new Array[3];
            PowerZoneData[0] = ZoneNumber;
            PowerZoneData[1] = LowerPowerZones();
            PowerZoneData[2] = UpperPowerZones();
            return PowerZoneData;
        }
    }
}

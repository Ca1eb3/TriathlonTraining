// Caleb Smith
// 09/05/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class BikePowerZones
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
        public double ZonesArray(int ArrayNumber, int NumberInArray)
        {
            if (ArrayNumber == 0)
            {
                return ZoneNumber[NumberInArray];
            }
            else if (ArrayNumber == 1)
            {
                return LowerPowerZones(NumberInArray);
            }
            else if (ArrayNumber == 2)
            {
                return UpperPowerZones(NumberInArray);
            }
            else
            {
                return 0.00;
            }
        }   
    }
}

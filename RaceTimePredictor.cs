// Caleb Smith
// 09/09/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class RaceTimePredictor
    {
        // t2=t1* (d2/d1)^b
        // b = 1.06 typically for running
        // Class Variables
        private int timeSeconds1 = 0;
        private double bFactor = 1.06;
        private int distance1 = 0;
        private int distance2 = 0;

        // encapsulation
        public int TimeSeconds1
        {
            get { return timeSeconds1; }
            set { timeSeconds1 = value; }
        }
        public double BFactor
        {
            get { return bFactor; }
            set { bFactor = value; }
        }
        public int Distance1
        {
            get { return distance1; }
            set { distance1 = value; }
        }
        public int Distance2
        {
            get { return distance2; }
            set { distance2 = value; }
        }

        // constructors
        public RaceTimePredictor() : this(0, 1.06, 0, 0)
        {

        }
        public RaceTimePredictor(int aTimeSeconds1, double aBFactor, int aDistance1, int aDistance2)
        {
            this.TimeSeconds1 = aTimeSeconds1;
            this.BFactor = aBFactor;
            this.Distance1 = aDistance1;
            this.Distance2 = aDistance2;
        }
        public RaceTimePredictor(int aTimeSeconds1, int aDistance1, int aDistance2): this(aTimeSeconds1, 1.06, aDistance1, aDistance2)
        {

        }
        // methods
        public override string ToString()
        {
            string message = "";
            message += "Time Seconds 1: " + TimeSeconds1 + "\n";
            message += "b Factor: " + BFactor + "\n";
            message += "Distance 1: " + Distance1 + "\n";
            message += "Distance 2: " + Distance2 + "\n";
            return message;
        }
        public int PredictTime2()
        {
            double TimeSeconds2 = TimeSeconds1 * (Math.Pow((Distance2 / Distance1), BFactor));
            int TimeSeconds2Rounded = Convert.ToInt32(TimeSeconds2);
            return TimeSeconds2Rounded;
        }
    }
}

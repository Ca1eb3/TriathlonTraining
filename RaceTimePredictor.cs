// Caleb Smith
// 09/09/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public static class RaceTimePredictor
    {
        // t2=t1* (d2/d1)^b
        // b = 1.06 typically for running
        // Class Variables
        
        //private int timeSeconds1 = 0;
        //private static double bFactor = 1.06;
        // Both distance must be in the same units can be either m or yds
       // private int distance1 = 0;
       // private int distance2 = 0;

        // encapsulation
        /*
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
        */
        public static int PredictTime2(int timeSeconds1, int distance1, int distance2)
        {
            double TimeSeconds2 = timeSeconds1 * Math.Pow(distance2 / distance1, 1.06);
            int TimeSeconds2Rounded = Convert.ToInt32(TimeSeconds2);
            return TimeSeconds2Rounded;
        }
        public static int PredictTime2Custom(int timeSeconds1, int distance1, int distance2, double bFactor)
        {
            double TimeSeconds2 = timeSeconds1 * (Math.Pow((distance2 / distance1), bFactor));
            int TimeSeconds2Rounded = Convert.ToInt32(TimeSeconds2);
            return TimeSeconds2Rounded;
        }
    }
}

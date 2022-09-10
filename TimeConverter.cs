// Caleb Smith
// 09/10/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class TimeConverter
    {
        // Class variables
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        // gets and sets
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0)
                {
                    hours = value;
                }
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0)
                {
                    minutes = value;
                }
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0)
                {
                    seconds = value;
                }
            }
        }

        // Constructors
        public TimeConverter(): this(0, 0, 0)
        {

        }
        public TimeConverter(int aHours, int aMinutes, int aSeconds)
        {
            Hours = aHours;
            Minutes = aMinutes;
            Seconds = aSeconds;
        }
        public TimeConverter(int aSeconds): this(0, 0, aSeconds)
        {

        }
        public TimeConverter(int aMinutes, int aSeconds): this(0, aMinutes, aSeconds)
        {

        }

        // Methods
        public override string ToString()
        {
            string message = "";
            message += "Hours: " + Hours + "\n";
            message += "Minutes: " + Minutes + "\n";
            message += "Seconds: " + Seconds + "\n";
            return message;
        }
        // Converts time to seconds
        public int ConvertedToSeconds()
        {
            int ConvertedSeconds = 0;
            ConvertedSeconds += (Hours * 3600) + (Minutes * 60) + Seconds;
            return ConvertedSeconds;
        }
        // Converts Seconds back to time
        public int[] ConvertedToTime()
        {
            int[] ConvertedTime = new int[3];
            ConvertedTime[0] = Seconds / 3600;
            Hours = ConvertedTime[0];
            Seconds = Seconds - (Hours * 3600);
            ConvertedTime[1] = Seconds / 60;
            Minutes = ConvertedTime[1];
            Seconds = Seconds - (Seconds * 60);
            ConvertedTime[2] = Seconds;
            return ConvertedTime;
        }
    }
}

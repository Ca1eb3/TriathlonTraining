// Caleb Smith
// 09/10/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public static class TimeConverter
    {
        // Methods
        // Converts time to seconds
        public static int ConvertedToSeconds(int Hours, int Minutes, int Seconds)
        {
            int ConvertedSeconds = 0;
            ConvertedSeconds += (Hours * 3600) + (Minutes * 60) + Seconds;
            return ConvertedSeconds;
        }
        // Converts Seconds back to time
        public static int ConvertedToTime(int Seconds, int V)
        {
            int[] ConvertedTime = new int[3];
            ConvertedTime[0] = Seconds / 3600;
            Seconds = Seconds - (ConvertedTime[0] * 3600);
            ConvertedTime[1] = Seconds / 60;
            Seconds = Seconds - (ConvertedTime[1] * 60);
            ConvertedTime[2] = Seconds;
            return ConvertedTime[V];
        }
    }
}

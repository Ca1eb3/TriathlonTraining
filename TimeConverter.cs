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
        // Displays Time in [h]:mm:ss format
        public static string DisplayTime(int hours, int minutes, int seconds)
        {
            if (hours == 0)
            {
                if (seconds < 10 && seconds > 0)
                {
                    return Convert.ToString($"{minutes}:0{seconds}");
                }
                else if (seconds == 0)
                {
                    return Convert.ToString($"{minutes}:00");
                }
                else
                {
                    return Convert.ToString($"{minutes}:{seconds}");
                }
            }
            else
            {
                if (minutes < 10 && minutes > 0)
                {
                    if (seconds < 10 && seconds > 0)
                    {
                        return Convert.ToString($"{hours}:0{minutes}:0{seconds}");
                    }
                    else if (seconds == 0)
                    {
                        return Convert.ToString($"{hours}:0{minutes}:00");
                    }
                    else
                    {
                        return Convert.ToString($"{hours}:0{minutes}:{seconds}");
                    }
                }
                else if (minutes == 0)
                {
                    if (seconds < 10 && seconds > 0)
                    {
                        return Convert.ToString($"{hours}:00:0{seconds}");
                    }
                    else if (seconds == 0)
                    {
                        return Convert.ToString($"{hours}:00:00");
                    }
                    else
                    {
                        return Convert.ToString($"{hours}:00:{seconds}");
                    }
                }
                else
                {
                    if (seconds < 10 && seconds > 0)
                    {
                        return Convert.ToString($"{hours}:{minutes}:0{seconds}");
                    }
                    else if (seconds == 0)
                    {
                        return Convert.ToString($"{hours}:{minutes}:00");
                    }
                    else
                    {
                        return Convert.ToString($"{hours}:{minutes}:{seconds}");
                    }
                }
            }
        }
    }
}

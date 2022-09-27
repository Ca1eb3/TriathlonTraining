// Caleb Smith
// 09/27/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public abstract class PaceZones
    {
        // class variables
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
        public PaceZones() : this(0, 0, 0)
        {

        }
        public PaceZones(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public PaceZones(int Minutes, int Seconds) : this(0, Minutes, Seconds)
        {

        }
        public PaceZones(int Seconds) : this(0, 0, Seconds)
        {

        }

        // Methods
        public abstract int PaceActual();
        public int PaceLower()
        {
            int pace = Convert.ToInt32(PaceActual() * .97);
            return pace;
        }
        public int PaceUpper()
        {
            int pace = Convert.ToInt32(PaceActual() * 1.03);
            return pace;
        }
        public string PaceString(int pace)
        {
            string time;
            time = TimeConverter.DisplayTime(TimeConverter.ConvertedToTime(pace, 0), TimeConverter.ConvertedToTime(pace, 1), TimeConverter.ConvertedToTime(pace, 2));
            return time;
        }
    }
}

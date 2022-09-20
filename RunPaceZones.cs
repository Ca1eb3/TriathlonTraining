// Caleb Smith
// 09/15/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class RunPaceZones
    {
        // class variables
        private int runHours = 0;
        private int runMinutes = 0;
        private int runSeconds = 0;
        private double distanceMeasured = 0;

        // gets and sets
        public int RunHours
        {
            get { return runHours; }
            set
            {
                if (value >= 0)
                {
                    runHours = value;
                }
            }
        }
        public int RunMinutes
        {
            get { return runMinutes; }
            set
            {
                if (value >= 0)
                {
                    runMinutes = value;
                }
            }
        }
        public int RunSeconds
        {
            get { return runSeconds; }
            set
            {
                if (value >= 0)
                {
                    runSeconds = value;
                }
            }
        }
        public double DistanceMeasured
        {
            get { return distanceMeasured; }
            set
            {
                if (value >= 0)
                {
                    distanceMeasured = value;
                }
            }
        }
        // constructors 
        public RunPaceZones(): this(0, 0, 0, 0)
        {

        }
        public RunPaceZones(int RunHours, int RunMinutes, int RunSeconds, double DistanceMeasured)
        {
            this.RunHours = RunHours;
            this.RunMinutes = RunMinutes;
            this.RunSeconds = RunSeconds;
            this.DistanceMeasured = DistanceMeasured;
        }
        public RunPaceZones(int RunMinutes, int RunSeconds, double DistanceMeasured) : this(0, RunMinutes, RunSeconds, DistanceMeasured)
        {

        }
        public RunPaceZones( int RunSeconds, double DistanceMeasured) : this(0, 0, RunSeconds, DistanceMeasured)
        {

        }

        // methods
        public override string ToString()
        {
            string message = "";
            message += $"Time: {RunHours}:{RunMinutes}:{RunSeconds}\nDistance: {DistanceMeasured}";
            return message;
        }
        public int PaceActual()
        {
            int pace = Convert.ToInt32(TimeConverter.ConvertedToSeconds(RunHours, RunMinutes, RunSeconds) / (DistanceMeasured / 1000));
            return pace;
        }
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
            string time = Convert.ToString($"{TimeConverter.ConvertedToTime(pace, 0)}:{TimeConverter.ConvertedToTime(pace, 1)}:{TimeConverter.ConvertedToTime(pace, 2)}");
            return time;
        }
    }
}

// Caleb Smith
// 09/27/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class RunThresholdPaceZones : PaceZones
    {
        // class variables
        private string zoneName = "Na";
        private double paceFactor = 0.00;

        // gets and sets
        public string ZoneName
        {
            get { return zoneName; }
            set { zoneName = value; }
        }
        public double PaceFactor
        {
            get { return paceFactor; }
            set { paceFactor = value; }
        }
        // constructors 
        public RunThresholdPaceZones() : this("na", 0.00, 0, 0, 0)
        {

        }
        public RunThresholdPaceZones(string ZoneName, double PaceFactor, int Hours, int Minutes, int Seconds) : base(Hours, Minutes, Seconds)
        {
            this.ZoneName = ZoneName;
            this.PaceFactor = PaceFactor;
        }
        public RunThresholdPaceZones(string ZoneName, double PaceFactor, int RunMinutes, int RunSeconds) : this(ZoneName, PaceFactor, 0, RunMinutes, RunSeconds)
        {

        }
        public RunThresholdPaceZones(string ZoneName, double PaceFactor, int RunSeconds) : this(ZoneName, PaceFactor, 0, 0, RunSeconds)
        {

        } 
        public RunThresholdPaceZones(string ZoneName, int RunHours, int RunMinutes, int RunSeconds) : this(ZoneName, 0.00, RunHours, RunMinutes, RunSeconds)
        {

        }

        // methods
        public override string ToString()
        {
            string message = "";
            message += $"Time: {Hours}:{Minutes}:{Seconds}\n";
            return message;
        }
        public override int PaceActual()
        {
            double paceDouble = TimeConverter.ConvertedToSeconds(Hours, Minutes, Seconds) / 3 * PaceFactor;
            int pace = Convert.ToInt32(paceDouble);
            return pace;
        }
    }
}

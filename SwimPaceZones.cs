using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriathlonTraining
{
    public class SwimPaceZones : PaceZones
    {
        // class variables
        private double distanceMeasured = 0;

        // gets and sets
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
        public SwimPaceZones() : this(0, 0, 0, 0)
        {

        }
        public SwimPaceZones(int Hours, int Minutes, int Seconds, double DistanceMeasured) : base(Hours, Minutes, Seconds)
        {
            this.DistanceMeasured = DistanceMeasured;
        }
        public SwimPaceZones(int Minutes, int Seconds, double DistanceMeasured) : this(0, Minutes, Seconds, DistanceMeasured)
        {

        }
        public SwimPaceZones(int Seconds, double DistanceMeasured) : this(0, 0, Seconds, DistanceMeasured)
        {

        }

        // Methods
        public override string ToString()
        {
            string message = "";
            message += $"Time: {Hours}:{Minutes}:{Seconds}\nDistance: {DistanceMeasured}";
            return message;
        }
        public override int PaceActual()
        {
            int pace = Convert.ToInt32(TimeConverter.ConvertedToSeconds(Hours, Minutes, Seconds) / (DistanceMeasured / 100));
            return pace;
        }
    }
}

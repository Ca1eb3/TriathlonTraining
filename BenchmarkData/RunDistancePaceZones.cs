// Caleb Smith
// 09/15/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriathlonTraining.CalculationTools;

namespace TriathlonTraining.BenchmarkData
{
    public class RunDistancePaceZones : PaceZones
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
        public RunDistancePaceZones(): this(0, 0, 0, 0)
        {

        }
        public RunDistancePaceZones(int Hours, int Minutes, int Seconds, double DistanceMeasured): base(Hours, Minutes, Seconds)
        {
            this.DistanceMeasured = DistanceMeasured;
        }
        public RunDistancePaceZones(int Minutes, int Seconds, double DistanceMeasured) : this(0, Minutes, Seconds, DistanceMeasured)
        {

        }
        public RunDistancePaceZones( int Seconds, double DistanceMeasured) : this(0, 0, Seconds, DistanceMeasured)
        {

        }

        // methods
        public override string ToString()
        {
            string message = "";
            message += $"Time: {Hours}:{Minutes}:{Seconds}\nDistance: {DistanceMeasured}";
            return message;
        }
        public override int PaceActual()
        {
            int pace = Convert.ToInt32(TimeConverter.ConvertedToSeconds(Hours, Minutes, Seconds) / (DistanceMeasured / 1000));
            return pace;
        }
    }
}

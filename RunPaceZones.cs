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
        // methods
    }
}

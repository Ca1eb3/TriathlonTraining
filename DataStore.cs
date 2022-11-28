// Caleb Smith
// 11/28/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriathlonTraining.BenchmarkData;

namespace TriathlonTraining
{
    public static class DataStore
    {
        // Class Variables
        private static BikePowerZones bikePowerZones = new BikePowerZones();
        private static Dictionary<int, RunDistancePaceZones> runDistancePaceZones = new Dictionary<int, RunDistancePaceZones>();
        private static Dictionary<string, RunThresholdPaceZones> runThresholdPaceZones = new Dictionary<string, RunThresholdPaceZones>();
        private static Dictionary<int, SwimPaceZones> swimPaceZones = new Dictionary<int, SwimPaceZones>();

        // gets and sets
        public static BikePowerZones BikePowerZones
        {
            get { return bikePowerZones; }
            set { bikePowerZones = value; }
        }
        public static Dictionary<int, RunDistancePaceZones> RunDistancePaceZones
        {
            get { return runDistancePaceZones; }
            set { runDistancePaceZones = value; }
        }
        public static Dictionary<string, RunThresholdPaceZones> RunThresholdPaceZones
        {
            get { return runThresholdPaceZones; }
            set { runThresholdPaceZones = value; }
        }
        public static Dictionary<int, SwimPaceZones> SwimPaceZones
        {
            get { return swimPaceZones; }
            set { swimPaceZones = value; }
        }
    }
}

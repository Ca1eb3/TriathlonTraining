using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TriathlonTraining.MainApplication;

namespace TriathlonTraining.MainApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Thread thread1 = new Thread(ThreadTasks.BenchmarkTestFormRun);
            thread1.Start();
        }
    }
}

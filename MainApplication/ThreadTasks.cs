// Caleb Smith
// 11/30/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriathlonTraining;

namespace TriathlonTraining.MainApplication
{
    public static class ThreadTasks
    {
        public static void MesaCycleFormRun()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MesaCycleForm());
        }
        public static void BenchmarkTestFormRun()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BenchmarkTestForm());
        }
    }
}

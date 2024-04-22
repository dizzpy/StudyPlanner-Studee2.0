using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DigitalStudyPlanner_Studee.Models
{
    public static class TimerManager
    {
        public static void InitializeTimer(System.Timers.Timer timer, double interval, ElapsedEventHandler elapsedEventHandler)
        {
            timer = new System.Timers.Timer();
            timer.Interval = interval;
            timer.Elapsed += elapsedEventHandler;
            timer.Start();
        }
    }
}

using DigitalStudyPlanner_Studee.Views;
using DigitalStudyPlanner_Studee.Views.Auth;
using DigitalStudyPlanner_Studee.Views.ToDoList;
using DigitalStudyPlanner_Studee.Views.UserControlViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToDoListItem());
        }
    }
}

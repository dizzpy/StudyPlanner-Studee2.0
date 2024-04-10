using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalStudyPlanner_Studee.Views.ToDoList
{
    public class TaskItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public DateTime AddedDate { get; set; }
        public bool IsCompleted { get; set; }
        public string TaskID { get; internal set; }

        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Priority: {Priority}, Added Date: {AddedDate}, Completed: {IsCompleted}";
        }
    }
}

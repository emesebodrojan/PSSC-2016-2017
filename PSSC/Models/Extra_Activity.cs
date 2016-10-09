using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Extra_Activity
    {
        protected int ExtraActivity_ID;
        protected string ExtraActivity_Name;
        protected Program Schedule;
        protected List<Student> Activity_Students;
        
        public Extra_Activity(int ExtraActivity_ID,string ExtraActivity_Name,Program Schedule, List<Student> Activity_Students )
        {
            this.ExtraActivity_ID = ExtraActivity_ID;
            this.ExtraActivity_Name = ExtraActivity_Name;
            this.Schedule = Schedule;
            this.Activity_Students = Activity_Students;
        }
    }

    public class Program
    {
        protected string Day;
        protected int Start_Hour;
        protected int End_Hour;

        public Program(string Day,int Start_Hour, int End_Hour)
        {
            this.Day = Day;
            this.Start_Hour = Start_Hour;
            this.End_Hour = End_Hour;
        }
    }
}

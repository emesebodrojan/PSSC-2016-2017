using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Extra_Activity
    {
        public int ExtraActivity_ID { get; set; }
        public string ExtraActivity_Name { get; set; }
        public Program Schedule { get; set; }
        public List<Student> Activity_Students { get; set; }

        public Extra_Activity()
        {
            this.Activity_Students = new List<Student> { null };
        }
        
        public Extra_Activity(int ExtraActivity_ID,string ExtraActivity_Name,Program Schedule, List<Student> Activity_Students ) :this()
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

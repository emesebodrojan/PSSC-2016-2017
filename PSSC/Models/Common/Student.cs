using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //A student has a registration number, name, a number of credits minimum to pass the year
    //a grade report he can request and a list of extra activities(sports, librarium)
    public class Student :Entity<RegistrationNumber>
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Models.Student.GradeReport GradeReport { get; set; }
        public List<Models.Student.ExtraActivity> ExtraActivity { get; set; }

        public Student(RegistrationNumber regNumber, PlainText name):base(regNumber)
        {
            RegNumber = regNumber;
            Name = name;
            ExtraActivity = new List<Models.Student.ExtraActivity>();
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits, Models.Student.GradeReport gradeReport,List<Models.Student.ExtraActivity> extraActivity)
            : this(regNumber, name)
        {
            RegNumber = regNumber;
            Name = name;
            Credits = credits;
            GradeReport = gradeReport;
            ExtraActivity = extraActivity;
        }

        public void addExtraActivity(Models.Student.ExtraActivity extAct)
        {
            ExtraActivity.Add(extAct);
        }
    }
}

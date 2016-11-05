using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //Entity
    public class Student :Entity<RegistrationNumber>
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Models.Student.GradeReport gradeReport { get; set; }
        public Models.Student.ExtraActivity extraActivity { get; set; }

        public Student(RegistrationNumber regNumber, PlainText name):base(regNumber)
        {
            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(regNumber, name)
        {
            Credits = credits;
        }
    }
}

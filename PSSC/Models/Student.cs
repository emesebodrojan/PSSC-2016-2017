using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Student_Type { Undergraduate, Graduate, Master, Doctorand}
    public class Student:Department
    {
        protected int Student_ID;
        protected string Student_Name;
        protected DateTime BirthDate;
        protected Student_Type Type;
        protected bool Scholarship;
        protected string Nationality;

        public Student(int Student_ID, string Student_Name, DateTime BirthDate, Student_Type Type, bool Scholarship, string Nationality,int Department_ID, string Department_Name, string Department_Major, List<Professor> Department_Professors, List<Student> Department_Students) : 
            base(Department_ID, Department_Name, Department_Major, Department_Professors, Department_Students)
        {
            this.Student_ID = Student_ID;
            this.Student_Name = Student_Name;
            this.BirthDate = BirthDate;
            this.Type = Type;
            this.Scholarship = Scholarship;
            this.Nationality = Nationality;
        }
    }
}

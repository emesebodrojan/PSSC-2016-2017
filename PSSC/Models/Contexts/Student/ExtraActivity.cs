using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    public class ExtraActivity
    {
        public Generics.PlainText Name { get; set; }
        public Generics.PlainText Description { get; set; }
        public int MaxStudentNumber { get; set; }
        public List<Common.Student> ActivityStudents { get; set; }

        public ExtraActivity()
        {
            ActivityStudents = new List<Common.Student>();
        }

        public ExtraActivity(Generics.PlainText name,Generics.PlainText description,int maxStudentNumber,List<Common.Student> activiyStudents)
        {
            Name = name;
            Description = description;
            MaxStudentNumber = maxStudentNumber;
            ActivityStudents = activiyStudents;
        }

        public void addActivityStudent(Common.Student student)
        {
            ActivityStudents.Add(student);
        }
    }
}

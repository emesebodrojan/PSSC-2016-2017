using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Department
{
    public class Department
    {
        public PlainText Name { get; internal set; }
        public DateTime StartDate { get; set; }
        public int NumberOfStudents { get; set; }
        public List<Common.Student> DepartmentStudents { get; set; }

        public Department()
        {
            DepartmentStudents = new List<Common.Student>();
        }

        public void addStudent(Common.Student student)
        {
            DepartmentStudents.Add(student);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    public class StudentList
    {
        public List<Models.Common.Student> Students { get; set; }
        public Common.Subject SubjectClass { get; set; }

        public StudentList()
        {
            Students = new List<Common.Student>();
        }
        public StudentList(List<Common.Student> students,Common.Subject subjectClass)
        {
            Students = students;
            SubjectClass = subjectClass;
        }

        public void addStudentToTheList(Common.Student student)
        {
            Students.Add(student);
        }
    }
}

using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //Entity
    public class Professor : Entity<PlainText>
    {
        public PlainText Name { get; internal set; }
        public string Speciality { get; set; }
        public Models.Department.Department Department { get; set; }
        public List<Student> StudentList { get; set; }
        public Dictionary<List<Student>, Subject> SignedUpStudents { get; set; }

        public Professor(PlainText name, string speciality, Department.Department department, Dictionary<List<Student>, Subject> signedUpStudents):base(name)
        {
            Name = name;
            Speciality = speciality;
            Department = department;
            SignedUpStudents = signedUpStudents;
        }

        public void addStudent(Student student, Subject subject)
        {
            StudentList.Add(student);
            SignedUpStudents.Add(StudentList, subject);
        }
    }
}

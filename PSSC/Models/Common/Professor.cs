using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //One professor has a name,a speciality that is teaching, a department where is assigned,a list of subject teaching,
    //a list of students and a dictionary where a certain subject has the students attending that class
    //He can add a student to a specific list of students that are attending a specific subject
    public class Professor : Entity<PlainText>
    {
        public PlainText Name { get; internal set; }
        public string Speciality { get; set; }
        public Models.Department.Department Department { get; set; }
        public List<Subject> SubjectsTeached { get; }
        public List<Student> StudentList { get; set; }
        public Dictionary<List<Student>, Subject> SignedUpStudents { get; set; }
        public Dictionary<Subject, Models.Subject.SubjectSituation> SubjectSituation { get; set; }

        public Professor(PlainText name, string speciality, Department.Department department, Dictionary<List<Student>, Subject> signedUpStudents):base(name)
        {
            Name = name;
            Speciality = speciality;
            Department = department;
            SignedUpStudents = signedUpStudents;
        }

        public void addStudent(Student student,List<Student> studentList, Subject subject)
        {
            studentList.Add(student);
            SignedUpStudents.Add(studentList, subject);
        }

        public void addStudentGrade(Subject subject,Models.Subject.SubjectSituation situation, Grade grade)
        {
            situation.AddActivityGrade(grade);
            SubjectSituation.Add(subject, situation);
        }
    }
}

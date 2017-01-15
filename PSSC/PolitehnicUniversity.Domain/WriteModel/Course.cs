using CQRSlite.Domain;
using PolitehnicUniversity.Domain.Events.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.WriteModel
{
    public class Course : AggregateRoot
    {
        private int _CourseID;
        private string _CourseName;
        private string _Teacher;
        private string _Description;
        private string _Mentions;
        private List<int> _Students;

        private Course() { }

        public Course(Guid id, int CourseID, string CourseName, string Teacher, string Description, string Mentions)
        {
            Id = id;
            _CourseID = CourseID;
            _CourseName = CourseName;
            _Teacher = Teacher;
            _Description = Description;
            _Mentions = Mentions;
            _Students = new List<int>();

            ApplyChange(new CourseCreatedEvent(id, CourseID, CourseName, Teacher, Description, Mentions));
        }

        public void AddStudent(int StudentID)
        {
            _Students.Add(StudentID);

            ApplyChange(new StudentAssignedToCourseEvent(Id, _CourseID, StudentID));
        }

        public void RemoveStudent(int StudentID)
        {
            _Students.Remove(StudentID);

            ApplyChange(new StudentRemovedFromCourseEvent(Id, _CourseID, StudentID));
        }
    }
}

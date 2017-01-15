using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.Events.Courses
{
    public class CourseCreatedEvent : BaseEvent
    {
        public readonly int CourseID;
        public readonly string CourseName;
        public readonly string Teacher;
        public readonly string Description;
        public readonly string Mentions;

        public CourseCreatedEvent(Guid id, int CourseID, string CourseName, string Teacher, string Description, string Mentions)
        {
            Id = id;
            CourseID = CourseID;
            CourseName = CourseName;
            Teacher = Teacher;
            Description = Description;
            Mentions = Mentions;
        }
    }
}

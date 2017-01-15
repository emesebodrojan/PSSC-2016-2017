using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.Events.Courses
{
    public class StudentRemovedFromCourseEvent : BaseEvent
    {
        public readonly int OldCourseID;
        public readonly int StudentID;

        public StudentRemovedFromCourseEvent(Guid id, int oldCourseID, int StudentID)
        {
            Id = id;
            OldCourseID = oldCourseID;
            StudentID = StudentID;
        }
    }
}

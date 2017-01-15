using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.Events.Courses
{
    public class StudentAssignedToCourseEvent : BaseEvent
    {
        public readonly int NewCourseID;
        public readonly int StudentID;

        public StudentAssignedToCourseEvent(Guid id, int newCourseID, int StudentID)
        {
            Id = id;
            NewCourseID = newCourseID;
            StudentID = StudentID;
        }
    }
}

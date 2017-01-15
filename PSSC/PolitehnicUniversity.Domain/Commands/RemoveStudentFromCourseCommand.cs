﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.Commands
{
    public class RemoveStudentFromCourseCommand : BaseCommand
    {
        public readonly int StudentID;
        public readonly int CourseID;

        public RemoveStudentFromCourseCommand(Guid id, int CourseID, int StudentID)
        {
            Id = id;
            StudentID = StudentID;
            CourseID = CourseID;
        }
    }
}

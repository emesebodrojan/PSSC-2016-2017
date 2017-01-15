using CQRSlite.Commands;
using CQRSlite.Domain;
using CQRSLiteDemo.Domain.Commands;
using CQRSLiteDemo.Domain.WriteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSLiteDemo.Domain.CommandHandlers
{
    public class CourseCommandHandler : ICommandHandler<CreateCourseCommand>,
                                          ICommandHandler<AssignStudentToCourseCommand>,
                                          ICommandHandler<RemoveStudentFromCourseCommand>
    {
        private readonly ISession _session;

        public CourseCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(CreateCourseCommand command)
        {
            var Course = new Course(command.Id, command.CourseID, command.CourseName, command.Teacher, command.Description, command.Mentions);
            _session.Add(Course);
            _session.Commit();
        }

        public void Handle(AssignStudentToCourseCommand command)
        {
            Course Course = _session.Get<Course>(command.Id);
            Course.AddStudent(command.StudentID);
            _session.Commit();
        }

        public void Handle(RemoveStudentFromCourseCommand command)
        {
            Course Course = _session.Get<Course>(command.Id);
            Course.RemoveStudent(command.StudentID);
            _session.Commit();
        }
    }
}

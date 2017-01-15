using CQRSlite.Commands;
using CQRSlite.Domain;
using PolitehnicUniversity.Domain.Commands;
using PolitehnicUniversity.Domain.WriteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.CommandHandlers
{
    public class StudentCommandHandler : ICommandHandler<CreateStudentCommand>
    {
        private readonly ISession _session;

        public StudentCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(CreateStudentCommand command)
        {
            Student Student = new Student(command.Id, command.StudentID, command.FirstName, command.LastName, command.DateOfBirth, command.StudyYear);
            _session.Add(Student);
            _session.Commit();
        }
    }
}

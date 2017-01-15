using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.Commands
{
public class CreateStudentCommand : BaseCommand
{
    public readonly int StudentID;
    public readonly string FirstName;
    public readonly string LastName;
    public readonly DateTime DateOfBirth;
    public readonly string StudyYear;

    public CreateStudentCommand(Guid id, int StudentID, string firstName, string lastName, DateTime dateOfBirth, string StudyYear)
    {
        Id = id;
        StudentID = StudentID;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        StudyYear = StudyYear;
    }
}
}

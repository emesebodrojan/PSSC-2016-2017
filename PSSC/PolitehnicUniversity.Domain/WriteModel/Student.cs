using CQRSlite.Domain;
using PolitehnicUniversity.Domain.Events.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.WriteModel
{
    public class Student : AggregateRoot
    {
        private int _StudentID;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _StudyYear;

        private Student() { }

        public Student(Guid id, int StudentID, string firstName, string lastName, DateTime dateOfBirth, string StudyYear)
        {
            Id = id;
            _StudentID = StudentID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _StudyYear = StudyYear;

            ApplyChange(new StudentCreatedEvent(id, StudentID, firstName, lastName, dateOfBirth, StudyYear));
        }
    }
}

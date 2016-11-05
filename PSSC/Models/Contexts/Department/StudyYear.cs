using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Deanship
{
    //Aggregate Root
    public class StudyYear
    {
        private List<Common.Subject> _definedSubjects { get; set; }

        public StudyYear()
        {
            _definedSubjects = new List<Common.Subject>();
        }

        public void DefineSubject(PlainText subjectName, Credits credits, Subject.EvaluationType type, Proportion activity)
        {
            Contract.Requires(subjectName != null, "Numele incorect!");
            Contract.Requires(credits != null, "Credits can not be null");
            Contract.Requires(type != null, "Type not null");
            Contract.Requires(activity != null, "Activty not null");

            var subjInfo = new Subject.SubjectInformation(subjectName, credits, type, activity);
            _definedSubjects.Add(new Common.Subject(subjInfo));
        }
        

        public void SignUpStudentToSubject(PlainText subjectName, Common.Student student)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(student != null, "student");

            _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).SignUpStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(regNumber != null, "regNumber");

            return _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).GetAverageForStudent(regNumber);
        }
        
    }
}

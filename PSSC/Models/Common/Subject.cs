using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //A subject has a name, information about who is teaching, number of credits,activity proportion and exam type.
    //Also a dictionary where a student has the situation for the current subject(attendence number, activity or exam grade)
    //
    public class Subject : Entity<PlainText>
    {
        public PlainText SubjectName { get; set; }
        public Models.Subject.SubjectInformation SubjectInfo { get; internal set; }
        public Dictionary<Common.Student, Models.Subject.SubjectSituation> SignedUpStudentsGrades { get; set; }
        public Subject(PlainText name):base(name)
        {
            SubjectName = name;
        }
        public Subject(PlainText name,Dictionary<Common.Student, Models.Subject.SubjectSituation> signedUpStudentsGrades, Models.Subject.SubjectInformation subjectInfo)
            :this(name)
        {
            SignedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }
        
        public Subject(Models.Subject.SubjectInformation sbjInfo):this()
        {
            this.SubjectInfo = sbjInfo;
        }

    }
}

using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //Entity
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

        public void SignUpStudent(Common.Student student)
        {
            SignedUpStudentsGrades.Add(student, new Models.Subject.SubjectSituation());
        }

        public Grade GetAverageForStudent(RegistrationNumber regNumber)
        {
            Models.Subject.SubjectSituation situation = SignedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;

            decimal activityGrade = situation.ActivityGrade.Value;
            decimal examAverage = situation.GetExamAverage(SubjectInfo.Evaluation);
            decimal proportion = SubjectInfo.ActivityProportion.Fraction;

            return new Grade(activityGrade * proportion + (1 - proportion) * examAverage);
        }

        public Models.Subject.SubjectSituation GetSituationForStudent(RegistrationNumber regNumber)
        {
            return SignedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }
    }
}

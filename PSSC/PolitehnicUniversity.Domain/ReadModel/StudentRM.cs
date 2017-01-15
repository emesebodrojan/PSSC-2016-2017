using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.ReadModel
{
    public class StudentRM
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudyYear { get; set; }
        public int CourseID { get; set; }
        public Guid AggregateID { get; set; }
    }
}

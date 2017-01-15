using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.ReadModel
{
    public class CourseRM
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public string Description { get; set; }
        public string Mentions { get; set; }
        public List<int> Students { get; set; }
        public Guid AggregateID { get; set; }

        public CourseRM()
        {
            Students = new List<int>();
        }
    }
}

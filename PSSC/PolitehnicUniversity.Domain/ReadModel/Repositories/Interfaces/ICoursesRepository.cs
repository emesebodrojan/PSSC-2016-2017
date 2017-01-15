using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.ReadModel.Repositories.Interfaces
{
    public interface ICourseRepository : IBaseRepository<CourseRM>
    {
        IEnumerable<CourseRM> GetAll();
        IEnumerable<StudentRM> GetStudents(int CourseID);
        bool HasStudent(int CourseID, int StudentID);
    }
}

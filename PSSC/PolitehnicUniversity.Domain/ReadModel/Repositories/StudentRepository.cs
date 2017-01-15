using PolitehnicUniversity.Domain.ReadModel.Repositories.Interfaces;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.ReadModel.Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(IConnectionMultiplexer redisConnection) : base(redisConnection, "Student") { }

        public StudentRM GetByID(int StudentID)
        {
            return Get<StudentRM>(StudentID);
        }

        public List<StudentRM> GetMultiple(List<int> StudentIDs)
        {
            return GetMultiple<StudentRM>(StudentIDs);
        }

        public IEnumerable<StudentRM> GetAll()
        {
            return Get<List<StudentRM>>("all");
        }

        public void Save(StudentRM Student)
        {
            Save(Student.StudentID, Student);
            MergeIntoAllCollection(Student);
        }

        private void MergeIntoAllCollection(StudentRM Student)
        {
            List<StudentRM> allStudents = new List<StudentRM>();
            if (Exists("all"))
            {
                allStudents = Get<List<StudentRM>>("all");
            }

            //If the district already exists in the ALL collection, remove that entry
            if (allStudents.Any(x => x.StudentID == Student.StudentID))
            {
                allStudents.Remove(allStudents.First(x => x.StudentID == Student.StudentID));
            }

            //Add the modified district to the ALL collection
            allStudents.Add(Student);

            Save("all", allStudents);
        }
    }
}

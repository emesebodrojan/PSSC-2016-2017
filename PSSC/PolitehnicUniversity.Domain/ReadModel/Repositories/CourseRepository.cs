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
public class CourseRepository : BaseRepository, ICourseRepository
{
    public CourseRepository(IConnectionMultiplexer redisConnection) : base(redisConnection, "Course") { }
    public CourseRM GetByID(int CourseID)
    {
        return Get<CourseRM>(CourseID);
    }

    public List<CourseRM> GetMultiple(List<int> CourseIDs)
    {
        return GetMultiple(CourseIDs);
    }

    public bool HasStudent(int CourseID, int StudentID)
    {
        //Deserialize the CourseDTO with the key Course:{CourseID}
        var Course = Get<CourseRM>(CourseID);

        //If that Course has the specified Student, return true
        return Course.Students.Contains(StudentID);
    }

    public IEnumerable<CourseRM> GetAll()
    {
        return Get<List<CourseRM>>("all");
    }
    public IEnumerable<StudentRM> GetStudents(int CourseID)
    {
        return Get<List<StudentRM>>(CourseID.ToString() + ":Students");
    }

    public void Save(CourseRM Course)
    {
        Save(Course.CourseID, Course);
        MergeIntoAllCollection(Course);
    }

    private void MergeIntoAllCollection(CourseRM Course)
    {
        List<CourseRM> allCourses = new List<CourseRM>();
        if (Exists("all"))
        {
            allCourses = Get<List<CourseRM>>("all");
        }

        //If the district already exists in the ALL collection, remove that entry
        if (allCourses.Any(x => x.CourseID == Course.CourseID))
        {
            allCourses.Remove(allCourses.First(x => x.CourseID == Course.CourseID));
        }

        //Add the modified district to the ALL collection
        allCourses.Add(Course);

        Save("all", allCourses);
    }
}
}

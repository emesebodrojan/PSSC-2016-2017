using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course : Department
    {
        protected int Course_ID;
        protected string Course_Name;
        protected string Course_Description;
        protected string Course_Language;
        protected int Total_Hours;
        protected List<Student> Course_Students;

        public Course(int Course_ID,string Course_Name,string Course_Description,string Course_Language,int Total_Hours, List<Student> Course_Students, int Department_ID, string Department_Name, string Department_Major, List<Professor> Department_Professors, List<Student> Department_Students) : 
            base(Department_ID, Department_Name, Department_Major, Department_Professors, Department_Students)
        {
            this.Course_ID = Course_ID;
            this.Course_Name = Course_Name;
            this.Course_Description = Course_Description;
            this.Course_Language = Course_Language;
            this.Total_Hours = Total_Hours;
            this.Course_Students = Course_Students;
        }
    }
}

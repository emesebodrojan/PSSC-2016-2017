using System;
using System.Collections.Generic;

namespace Models
{
    public class Department
    {
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Department_Major { get; set; }
        public List<Professor> Department_Professors { get; set; }
        public List<Student> Department_Students { get; set; }

        public Department()
        {
            this.Department_Professors = new List<Professor> { null };
            this.Department_Students = new List<Student> { null };
        }

        public Department(int Department_ID, string Department_Name, string Department_Major,List<Professor> Department_Professors, List<Student> Department_Students) : this()
        {
            this.Department_ID = Department_ID;
            this.Department_Name = Department_Name;
            this.Department_Major = Department_Major;
            this.Department_Professors = Department_Professors;
            this.Department_Students = Department_Students;
        }
        
    }
}
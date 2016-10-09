using System;
using System.Collections.Generic;

namespace Models
{
    public class Department
    {
        int Department_ID { get; set; }
        string Department_Name { get; set; }
        string Department_Major { get; set; }
        List<Professor> Department_Professors { get; set; }
        List<Student> Department_Students { get; set; }

        public Department(int Department_ID, string Department_Name, string Department_Major,List<Professor> Department_Professors, List<Student> Department_Students)
        {
            this.Department_ID = Department_ID;
            this.Department_Name = Department_Name;
            this.Department_Major = Department_Major;
            this.Department_Professors = Department_Professors;
            this.Department_Students = Department_Students;
        }
            
        public int department_ID
        {
            set { this.Department_ID = value; }
            get { return this.Department_ID; }
        }

        public string department_Name
        {
            set { this.Department_Name = value; }
            get { return this.Department_Name; }
        }

        public string major
        {
            set { this.Department_Name = value; }
            get { return this.Department_Major; }
        }
        public List<Professor> proffesors
        {
            set { this.Department_Professors = value; }
            get { return this.Department_Professors; }
        }
        public List<Student> students
        {
            set { this.Department_Students = value; }
            get { return this.Department_Students; }
        }
    }
}
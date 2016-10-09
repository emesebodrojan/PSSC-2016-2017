using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Professor
    {
        protected int Professor_ID;
        protected string Professor_Name;
        protected string Professor_Speciality;
        protected int Experience_Years;
        protected List<Student> Professor_Students;

        public Professor(int Professor_ID,string Professor_Name, string Professor_Speciality,int Experience_Years,List<Student> Professor_Students)
        {
            this.Professor_ID = Professor_ID;
            this.Professor_Name = Professor_Name;
            this.Professor_Speciality = Professor_Speciality;
            this.Experience_Years = Experience_Years;
            this.Professor_Students = Professor_Students;
        }
    }
}

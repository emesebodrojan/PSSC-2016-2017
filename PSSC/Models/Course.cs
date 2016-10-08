using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    class Course : iCourse
    {
        private int Course_ID;
        private String C_Name;
        private int Student_nr;
        private String Dep_Name;
        private String Admin;
        private int University_ID;
        private String Univ_Name;
        private DateTime startDate;
        private String dean;

        int iCourse.Course_ID
        {
            get
            {
                return Course_ID;
            }

            set
            {
                Course_ID = value;
            }
        }

        string iCourse.C_Name
        {
            get
            {
                return C_Name;
            }

            set
            {
                C_Name = value;
            }
        }

        int iCourse.Student_nr
        {
            get
            {
                return Student_nr;
            }

            set
            {
                Student_nr = value;
            }
        }

        string iDepartment.Admin
        {
            get
            {
                return Admin;
            }

            set
            {
                Admin = value;
            }
        }

        string iUniversity.Dean
        {
            get
            {
                return dean;
            }

            set
            {
                dean = value;
            }
        }

        int iDepartment.Department_ID
        {
            get
            {
                return Department_ID;
            }

            set
            {
                Department_ID = value;
            }
        }

        string iDepartment.Dep_Name
        {
            get
            {
                return Dep_Name;
            }

            set
            {
                Dep_Name = value;
            }
        }

        string iUniversity.Name
        {
            get
            {
                return Univ_Name;
            }

            set
            {
                Univ_Name = value;
            }
        }

        DateTime iUniversity.StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        int iUniversity.University_ID
        {
            get
            {
                return University_ID;
            }

            set
            {
                University_ID = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student : iStudent
    {
        private int Student_ID;
        private String Stud_Name;
        private DateTime BirthDate;
        private DateTime Enrolment_Date; 
        private int Department_ID;
        private String Dep_Name;
        private String Admin;
        private int University_ID;
        private String Univ_Name;
        private DateTime startDate;
        private String dean;

        DateTime iStudent.BirthDate
        {
            get
            {
                return BirthDate;
            }

            set
            {
                BirthDate = value;
            }
        }

        DateTime iStudent.Enrolment_Date
        {
            get
            {
                return Enrolment_Date;
            }

            set
            {
                Enrolment_Date = value;
            }
        }

        int iStudent.Student_ID
        {
            get
            {
                return Student_ID;
            }

            set
            {
                Student_ID = value;
            }
        }

        string iStudent.Stud_Name
        {
            get
            {
                return Stud_Name;
            }

            set
            {
                Stud_Name = value;
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

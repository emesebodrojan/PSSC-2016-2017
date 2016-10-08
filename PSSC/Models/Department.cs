using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Department : iDepartment
    {
        private int Department_ID;
        private String Dep_Name;
        private String Admin;
        private int University_ID;
        private String Univ_Name;
        private DateTime startDate;
        private String dean;

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

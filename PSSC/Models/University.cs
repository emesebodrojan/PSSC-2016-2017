using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class University : iUniversity
    {
        private int University_ID;
        private String Name;
        private DateTime StartDate;
        private String Dean;

        string iUniversity.Dean
        {
            get
            {
                return Dean;
            }

            set
            {
                Dean = value;
            }
        }

        string iUniversity.Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        DateTime iUniversity.StartDate
        {
            get
            {
                return StartDate;
            }

            set
            {
                value = StartDate;
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

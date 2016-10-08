using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface iStudent:iDepartment
    {
        int Student_ID { get; set; }
        String Stud_Name { get; set; }
        DateTime BirthDate { get; set; }
        DateTime Enrolment_Date { get; set; }
    }
}

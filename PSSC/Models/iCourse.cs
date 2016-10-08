using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface iCourse :iDepartment
    {
        int Course_ID { get; set; }
        String C_Name { get; set; }
        int Student_nr { get; set; }
    }
}

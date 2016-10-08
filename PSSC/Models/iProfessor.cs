using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface iProfessor:iDepartment
    {
        int Professor_ID { get; set; }
        String Prof_Name { get; set; }
        DateTime start_Time { get; set; }
    }
}

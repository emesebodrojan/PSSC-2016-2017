using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface iDepartment : iUniversity
    {
        int Department_ID { get; set; }
        String Dep_Name { get; set; }
        String Admin { get; set; }
    }
}

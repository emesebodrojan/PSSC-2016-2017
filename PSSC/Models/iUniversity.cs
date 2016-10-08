using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface iUniversity
    {
        int University_ID { get; set; }
        String Name { get; set; }
        DateTime StartDate { get; set; }
        String Dean { get; set; }
    }
}

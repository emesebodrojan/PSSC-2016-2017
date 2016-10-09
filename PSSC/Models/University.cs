using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class University
    {
        private int University_ID;
        private String University_Name;
        private DateTime Founding_Year;
        private bool International_Program;
        private List<Department> University_Dep;

        public University(int University_ID, string University_Name,DateTime Founding_Year,bool International_Program,List<Department> University_Dep)
            {
            this.University_ID = University_ID;
            this.University_Name = University_Name;
            this.Founding_Year = Founding_Year;
            this.International_Program = International_Program;
            this.University_Dep = University_Dep;
            }
    }
}

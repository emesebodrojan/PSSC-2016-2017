using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            Contract.Requires<ArgumentException>(value > 0, "Nota nu poate fi negativa!");
            Contract.Requires<ArgumentException>(value <= 10, "Nota maxima este 10");

            _value = value;
        }
    }
}

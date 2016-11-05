using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires<ArgumentNullException>(number != null, "Numarul de inregistarare nu poate fi null");

            _number = number;
        }
    }
}

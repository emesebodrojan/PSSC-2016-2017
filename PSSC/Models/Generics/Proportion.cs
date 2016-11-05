using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class Proportion
    {
        private int _numerator;
        private int _denominator;
        public decimal Fraction { get { return _numerator / _denominator; } }

        public Proportion(int numerator, int denominator)
        {
            Contract.Requires<ArgumentException>(denominator > 0, "Numitorul nu poate fi zero");
            Contract.Requires<ArgumentException>(numerator < denominator, "Fractia nu poate fi subunitara");

            _numerator = numerator;
            _denominator = denominator;
        }
    }
}

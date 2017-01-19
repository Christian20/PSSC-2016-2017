using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
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
            if (_value < 0 || _value > 10)
                throw new InvalidGradeValue("Illegal");
            _value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Credite
    {
        private decimal numar;
        public decimal Numar
        {
            get
            {
                return this.numar;
            }
        }

        public Credite(decimal numar)
        {
            Contract.Requires<ArgumentOutOfRangeException>(this.numar >= 0, "numar");
            Contract.Requires<ArgumentOutOfRangeException>(this.numar <= 6, "numar");

            this.numar = numar;
        }

  
        public override bool Equals(object obj)
        {
            var nota = (Nota)obj;
            return Numar == nota.Numar;
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Numar);
        }
    }
}

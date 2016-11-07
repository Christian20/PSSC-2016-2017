using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Varsta
    {
        private int numar;

        public Varsta(int numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "numar");
            Contract.Requires<ArgumentOutOfRangeException>(numar < 18, "Varsta minima este 18 ani");
            this.numar = numar;
            
        }

        public int Numar
        {
            get
            {
                return this.numar;
            }
            private set
            {
                this.numar = value;
            }
        }

        public override bool Equals(object obj)
        {
            return Numar.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

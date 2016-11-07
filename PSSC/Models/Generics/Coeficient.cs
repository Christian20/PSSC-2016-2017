using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Coeficient
    {
        private int numarator;
        private int numitor;

        public decimal Fractie { get { return (decimal)numarator / (decimal)numitor; } }

        internal Coeficient(int numarator, int numitor)
        {
            Contract.Requires<ArgumentException>(numarator > 0, "numarator");
            Contract.Requires<ArgumentException>(numitor > 0, "numitor");
            Contract.Requires<ArgumentException>(numitor > numarator, "nu este subunitar");

            this.numitor = numitor;
            this.numarator = numarator;
        }

        
        public override bool Equals(object obj)
        {
            var coeficient = (Coeficient)obj;
            return coeficient.numarator == numarator && coeficient.numitor == numitor;
        }

        public override int GetHashCode()
        {
            return Fractie.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", this.numarator, this.numitor);
        }
        
    }
}

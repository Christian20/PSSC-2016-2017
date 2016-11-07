using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class CNP
    {
        private long CodNumericPersonal { get; }

        public CNP(long cnp)
        {
            Contract.Requires<ArgumentOutOfRangeException>(cnp.ToString().Length == 13, "CNP-ul este format din 13 caractere");
            this.CodNumericPersonal = cnp;
            
        }

        public override bool Equals(object obj)
        {
            var cnp = (CNP)obj;
            return CodNumericPersonal == cnp.CodNumericPersonal;
        }

        public override int GetHashCode()
        {
            return CodNumericPersonal.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", CodNumericPersonal);
        }

    }
}

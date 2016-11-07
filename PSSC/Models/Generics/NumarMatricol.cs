using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class NumarMatricol
    {
        private string numar;

        public NumarMatricol(string numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "text");
            Contract.Requires<ArgumentException>(numar.Length == 5, "Numarul matricol este format din 5 caractere!");
            this.numar = numar;
        }

        public string Numar
        {
            get
            {
                return this.numar;
            }
        }

        public override string ToString()
        {
            return Numar.ToString();
        }

        public override bool Equals(object obj)
        {
            return Numar.Equals(obj);
        }
        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }



    }
}

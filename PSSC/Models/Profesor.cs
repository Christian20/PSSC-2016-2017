using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models
{
    public class Profesor
    {
        private CNP CNP { get; }
        private PlainText Nume { get; }
        private DataNasterii DataNasterii { get; }

        public Profesor(PlainText Nume,CNP CNP, DataNasterii DataNasterii)
        {
            this.Nume = Nume;
            this.CNP = CNP;
            this.DataNasterii = DataNasterii;
        }

        public override string ToString()
        {
            return string.Format("Nume: {0}, CNP: {1}, Data Nasterii: {2}", Nume, CNP, DataNasterii);
        }

    }
}

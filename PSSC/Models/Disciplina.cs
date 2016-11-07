using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models
{
    public class Disciplina
    {
        private Profesor ProfesorDisciplina { get; }
        private PlainText NumeDisciplina { get; }
        private Credite Credit { get; }
        private int Ore { get; }

        public Disciplina(Profesor profesor,PlainText nume,Credite Credit,int Ore)
        {
            this.ProfesorDisciplina = profesor;
            this.NumeDisciplina = nume;
            this.Credit = Credit;
            this.Ore = Ore;
        }

        public override string ToString()
        {
            return string.Format("Denumire: {0}, Profesor: {1}, Credite: {2}, Ore: {3}",NumeDisciplina, ProfesorDisciplina, Credit, Ore);
        }



    }
}

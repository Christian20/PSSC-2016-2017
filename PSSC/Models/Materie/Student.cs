using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;

namespace Models.Materie
{

    public enum NumeFacultate { AC, ETC, EE };
    public enum An { I, II, III, IV, extensie };
    public enum Serie { IS, CTI };


    public class Student
    {
        public NumarMatricol NumarMatricol { get; }
        public PlainText Nume { get; }
        public An An { get; }
        public NumeFacultate Facultate { get; }
        public Serie Serie { get; }
        public Note Note {get; }

        public Student(NumarMatricol nr_matricol, PlainText nume, NumeFacultate facultate, Serie serie, An an, Note note)
        {
            this.NumarMatricol = nr_matricol;
            this.Nume = nume;
            this.Facultate = facultate;
            this.Serie = serie;
            this.An = an;
            this.Note = note;
        }

        public override string ToString()
        {
            return string.Format("Nume: {0}, Numar Matricol: {1}, An Studiu: {2}, Facultate: {3}, Serie: {4}, Note: {5}", Nume, NumarMatricol, An, Facultate, Serie, Note);
        }

    }

}

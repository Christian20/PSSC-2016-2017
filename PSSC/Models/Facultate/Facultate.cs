using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using Models.Facultate.Exceptions;

namespace Models.Facultate
{
    //Aggregation root "Facultate" -> Formata din Lista de Studenti, Lista de profesori si Lista de Discipline
    //Metode de inscriere a unui Student/Profesor/Disciplina noua

    public class Facultate
    {
        public PlainText NumeFacultate { get; private set;} // Identificator Unic
        private List<Student> Studenti;
        private List<Disciplina> Discipline;
        private List<Profesor> Profesori;


        //Crearea unei noi facultati
        public Facultate(PlainText NumeFacultate)
        {
            this.NumeFacultate = NumeFacultate;
            Studenti = new List<Student>();
            Discipline = new List<Disciplina>();
            Profesori = new List<Profesor>();
        }

        //Afisare lista Studenti

        public IEnumerable<Student> StudentiInscrisi
        {
            get
            {
                return Studenti;
            }
        }

        //Inscrie Student Nou

        public void InscrieStudent(Student student)
        {
            if (Studenti.FindAll( s => s.An.Equals(student.Serie)).Count < 150)
            {
                
                bool gasit = (Studenti.FirstOrDefault(s => s.Equals(student)) != null) ? true : false;
                if (gasit == true)
                {
                    Studenti.Add(student);
                }
                else
                {
                    throw new StudentulExistaException();
                }
            }
            else
            {
                throw new LimitaAtinsaStudentiExcepton();
            }
        }

        //Afisare Discipline
        public IEnumerable<Disciplina> ListaDiscipline
        {
            get
            {
                return Discipline;
            }
        }


        //Adauga Disciplina noua in lista de discipline

        public void AdaugaDisciplinaNoua(Disciplina disciplina)
        {
            bool gasit = (Discipline.FirstOrDefault(s => s.Equals(disciplina)) != null) ? true : false;
            if (gasit == true)
            {
                Discipline.Add(disciplina);
            }
            else
            {
                throw new DisciplinaExistaException();
            }
        }

        //Afisare Lista de profesori din cadrul facultatii

        public IEnumerable<Profesor> ListaProfesori
        {
            get
            {
                return Profesori;
            }
        }


        //Adauga profesor noua in lista de profesori

        public void AdaugaProfesorNou(Profesor profesor)
        {
            bool gasit = (Profesori.FirstOrDefault(s => s.Equals(profesor)) != null) ? true : false;
            if (gasit == true)
            {
                Profesori.Add(profesor);
            }
            else
            {
                throw new ProfesorulExistaException();
            }
        }

        public override string ToString()
        {
            return NumeFacultate.ToString();
        }

        public override bool Equals(object obj)
        {
            var facultate = (Facultate)obj;

            if (facultate != null)
            {
                return NumeFacultate.Equals(facultate.NumeFacultate);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NumeFacultate.GetHashCode();
        }



    }
}

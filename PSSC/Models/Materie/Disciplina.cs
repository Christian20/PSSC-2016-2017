using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;


namespace Models.Materie
{
    public class Disciplina
    {
        public PlainText NumeDisciplina { get; private set; }
        private List<Student> Studenti;
        public Profesor Profesor { get; private set; }
     
        public Disciplina(PlainText NumeDisciplina, Profesor prof)
        {
            this.NumeDisciplina = NumeDisciplina;
            Studenti = new List<Student>();
            Profesor = prof;
        }

        public IEnumerable<Student> StudentiInscrisi
        {
            get
            {
                return Studenti;
            }
        }

        public void InscrieStudent(Student student)
        {
            if (Studenti.FindAll(s => s.An.Equals(student.Serie)).Count < 150)
            {

                bool gasit = (Studenti.FirstOrDefault(s => s.Equals(student)) != null) ? true : false;
                if (gasit == true)
                {
                    Studenti.Add(student);
                }
                else
                {
                    throw new Facultate.Exceptions.StudentulExistaException();
                }
            }
            else
            {
                throw new Facultate.Exceptions.LimitaAtinsaStudentiExcepton();
            }
        }

        public void AtribuieProfesor(Profesor prof)
        {
            this.Profesor = prof;
        }

        public bool PromovabilitateStudent(Student stud)
        {
            if (this.Studenti.Contains(stud))
            {
                if (stud.Note.Media.Numar > 5)
                    return true;
                else
                    return false;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

    }

}

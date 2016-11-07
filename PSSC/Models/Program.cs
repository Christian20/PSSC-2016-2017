using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Start of application!");

            Profesor profesor = new Profesor("Gheorghe-Daniel Andreescu");
            List<Disciplina> discipline = new List<Disciplina>();
            discipline.Add(new Disciplina(profesor, "FIETC", 5, 20));
            discipline.Add(new Disciplina(profesor, "PCDD", 5, 20));
            discipline.Add(new Disciplina(profesor, "CAEHP", 5, 20));



            Student student = new Student("Christian", Facultate.AC, "IP", 4, discipline);
            student.Print();

            Console.ReadKey();
        }

    }
}

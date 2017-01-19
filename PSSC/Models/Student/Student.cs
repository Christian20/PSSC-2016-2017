using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public Guid Id;
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Student(RegistrationNumber regNumber, PlainText name)
        {
            if (RegNumber!=regNumber && PlainText.Compare(Name,name)==0)
            {
                throw new InexistingStudent("Student does not exist!");
            }
            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(regNumber, name)
        {
            Credits = credits;
        }
    }
}

using Models.Generics;
using Models.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class SubjectsRepository : IRepository<Subjects>
    {
        private List<Subjects> subjectlist;

        public SubjectsRepository(List<Subjects> subjectlist)
        {
            this.subjectlist = subjectlist;
        }
        public void Add(Subjects sub)
        {
            subjectlist.Add(sub);
        }
        public void Delete(Subjects sub)
        {
            subjectlist.Remove(sub);
        }
        public Subjects GetById(Guid Id)
        {
            return subjectlist.FirstOrDefault(s => s.Id.Equals(Id));
        }
        public void AddExamGrade(Guid Id,PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            var subject = GetById(Id);
            subject.AddExamGrade(subjectName, regNumber, grade);
        }
    }
}

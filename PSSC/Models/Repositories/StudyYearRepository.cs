using Models.Deanship;
using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    class StudyYearRepository : IRepository<StudyYear>
    {
        private List<StudyYear> definedsubjects;

        public StudyYearRepository(List<StudyYear> defindesubjects)
        {
            this.definedsubjects = defindesubjects;
        }
        void Add(StudyYear sub)
        {
            definedsubjects.Add(sub);
        }
        void Delete(StudyYear sub)
        {
            definedsubjects.Remove(sub);
        }
        StudyYear GetById(Guid Id)
        {
            return definedsubjects.FirstOrDefault(d => d.Id.Equals(Id));
        }
        public void DefineSubject(Guid Id, PlainText subjectName, Credits credits, EvaluationType type, Proportion activity)
        {
            var subject = GetById(Id);
            subject.DefineSubject(subjectName, credits, type, activity);
        }
    }
}

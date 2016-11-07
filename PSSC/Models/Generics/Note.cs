using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics.Exceptions;

namespace Models.Generics
{
    public class Note
    {
        private List<Nota> note;
        public ReadOnlyCollection<Nota> Valori { get { return note.AsReadOnly(); } }

        public Note()
        {
            note = new List<Nota>();
        }

        //acest constructor este internal pentru ca ar trebui sa fie folosit doar din repository
        internal Note(List<Nota> note)
        {
            Contract.Requires(note != null, "lista de note");
            this.note = note;
        }

        public Nota Media
        {
            get
            {
                if (this.note.Count < 2) throw new Exceptions.NoteInsuficiente();
                return new Nota(this.note.Select(n => n.Numar).Average());
            }
        }

        internal void AdaugaNota(Nota nota)
        {
            Contract.Requires(nota != null, "nota");
            note.Add(nota);
        }

        
        public override string ToString()
        {
            string NoteAdunate = "";

            foreach (Nota n in note) {
                NoteAdunate = n + ", ";
            }

            return NoteAdunate;


        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

    }
}
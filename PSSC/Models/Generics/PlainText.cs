using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class PlainText
    {
        private string text;

        public PlainText(string text)
        {
            Contract.Requires<ArgumentNullException>(text != null, "text");
            this.text = text;
        }

        public string Text
        {
            get
            {
                return this.text;
            }
           
        }
        
        public override string ToString()
        {
            return Text;
        }
        public override bool Equals(object obj)
        {
            return obj.Equals(this);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

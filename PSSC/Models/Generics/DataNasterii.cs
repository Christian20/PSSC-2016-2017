using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class DataNasterii
    {
        private DateTime data;

        public DataNasterii(DateTime data)
        {
            Contract.Requires<ArgumentNullException>(data != null, "data");
            if (DateTime.TryParseExact("15/07/2015", new[] { "dd/MM/yyyy", "yyyy-MM-dd" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                this.data = data;
            }
            else
            {
                throw new CultureNotFoundException("nu este formatul potrivit");
            }
        }

        public DateTime Data
        {
            get
            {
                return this.data;
            }
        }
        public override string ToString()
        {
            return Data.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

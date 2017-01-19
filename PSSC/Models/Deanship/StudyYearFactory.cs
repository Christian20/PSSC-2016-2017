using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Deanship
{
    public class StudyYearFactory
    {
        public static StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        {
        }

        public static StudyYear CreateStudyYear()
        {
            var studyyear = new StudyYear();
            return studyyear;
        }
    }
}

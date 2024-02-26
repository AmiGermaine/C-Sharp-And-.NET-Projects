using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class Grade
    {
        public int GradeID;
        public string GradeName;

        public ICollection<Student> Students;
    }
}

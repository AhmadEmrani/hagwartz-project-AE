using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Student : Permissible_Persons
    {
        public List<string> passedlessons { get; set; }
        public int term_num { get; set; }
        public int dorm_num { get; set; } //khabgah
    }
}

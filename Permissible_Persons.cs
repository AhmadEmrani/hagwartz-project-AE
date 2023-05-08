using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Permissible_Persons : Human
    {
        public int NUmberroom { get; set; }
        public string schedule { get; set; }
        public Pet Petofpersons { get; set; }  

    }
    enum Pet
    {
        i,
        cat,
        rat
    }
}

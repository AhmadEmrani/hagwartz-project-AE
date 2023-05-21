using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Permissible_Persons : Human
    {
        public int nUmberroom { get; set; }
        public string schedule { get; set; }
        public Pet petofpersons { get; set; }
        bool Suitcase { get; set; }
        public role roleofpersons { get; set; }
        public string postmessage { get; set; } 
        public Group persongroup { get; set; }
    }
    public enum Pet
    {
        owl,
        cat,
        rat
    }
    public enum role
    {
        teacher,
        student
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Group
    {
        public groupname Nameofgroup { get; set; }
        public int score { get; set; }
        public List<string> members { get; set; }
        public List<string> gameQuidish { get; set; }
    }
    public enum groupname
    {
        Hufflepuff,
        Gryffindor, 
        Ravenclaw, 
        Slytherin
    }
}

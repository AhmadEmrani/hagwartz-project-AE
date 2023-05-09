using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Human
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public string dateofbirth { get; set; }
        public string gender { get; set; }
        public string father { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public blood bloodname { get; set; }
    }
    enum blood
    {
        Muggleblood,
        Pureblood,
        Halfblood
    }
}

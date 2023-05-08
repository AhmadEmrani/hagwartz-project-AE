using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Human
    {
        public string Name { get; set; }
        public string Familyname { get; set; }
        public string Dateofbirth { get; set; }
        public string Gender { get; set; }
        public string father { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Blood Bloodname { get; set; }
    }
    enum Blood
    {
        Muggleblood,
        Pureblood,
        Halfblood
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader("file.tsv"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] human = ln.Split('\t').ToArray<string>();
                    /*
                    human[0] = name
                    human[1] = family
                    human[2] = dataOfBirth
                    human[3] = gender
                    human[4] = father
                    human[5] = username
                    human[6] = password
                    human[7] = race type
                    human[8] = role
                    */
                }
                file.Close();
            }


        }
    }
}

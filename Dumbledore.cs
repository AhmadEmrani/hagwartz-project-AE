using project_1_and_other_stuff;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Dumbledore : Permissible_Persons
    {
        private static Dumbledore instance = null;
        private static readonly object Instancelock = new object();

        private Dumbledore() { }

        public static Dumbledore GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Dumbledore();
                        }

                    }
                }
                return instance;
            }

        }
        //public static void PassCode()
        //{
        //    //Random rnd = new Random();

        //    //for (int j = 0; j < 4; j++)
        //    //{
        //    //    Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20
        //    //}


        //    // making table 
        //    //

        //    Random rnd = new Random();
        //    int size_table = rnd.Next(5,8);
        //    for(int i=0 ; i<((size_table+1)+(size_table*2));i++)
        //    {
        //        Console.Write("_");
        //    }
        //    Console.Write("\n");
        //    for (int J = 0; J < ((size_table + 1) + (size_table * 2)); J++)
        //    {
        //        for (int i = 0; i < ((size_table + 1) + (size_table * 2)); i++)
        //        {
        //            if ((i % 3) == 0)
        //            {
        //                Console.Write("|");
        //            }
        //            else
        //            {
        //                Console.Write(" ");
        //            }
        //        }
        //        if (J != ((size_table + 1) + (size_table * 2)) )
        //        {
        //            Console.Write("\n");
        //        }
            
        //    }
        //    for (int i = 0; i < ((size_table + 1) + (size_table * 2)); i++)
        //    {
        //        Console.Write("_");
        //    }
        //    Console.ReadKey();

        //}
        public static int DisplayAction()
        {
            int final = 0;
            Cw.WriteColor("[chose one of action below master ! ]", ConsoleColor.DarkRed);
            Cw.collumright();
            Cw.WriteColor("[Sent invitation]      (1)", ConsoleColor.Green);
            Cw.collumright();
            Cw.WriteColor("[Requests from student]      (2)", ConsoleColor.Green);
            Cw.collumright();
            Cw.WriteColor("[Dorm system]      (3)", ConsoleColor.Green);
            Cw.collumright();
            Console.Write("your choice : ");
            final = int.Parse(Console.ReadLine());
            return final;
        }
        public static void Sending_Invitation(List<Permissible_Persons> peoples , List<Student> studentss)
        {
            foreach(Permissible_Persons permited in peoples)
            {
                if(permited.roleofpersons == role.student)
                {
                    Student instasncestudent = new Student();
                    instasncestudent.name= permited.name;
                    instasncestudent.familyname= permited.familyname;
                    instasncestudent.dateofbirth = permited.dateofbirth;
                    instasncestudent.gender= permited.gender;
                    instasncestudent.father= permited.father;
                    instasncestudent.username = permited.username; 
                    instasncestudent.password= permited.password;
                    instasncestudent.bloodname= permited.bloodname;
                    instasncestudent.roleofpersons= permited.roleofpersons; 
                    ///////////////// invitation message :)
                    studentss.Add(instasncestudent);
                }
            }
            
        }
    }
}

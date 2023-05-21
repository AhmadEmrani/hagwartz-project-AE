using project_1_and_other_stuff;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
        public static void Sending_Invitation(List<Permissible_Persons> peoples, List<Student> studentss)
        {
            foreach (Permissible_Persons permited in peoples)
            {
                if (permited.roleofpersons == role.student)
                {
                    Student instasncestudent = new Student();
                    instasncestudent.name = permited.name;
                    instasncestudent.familyname = permited.familyname;
                    instasncestudent.dateofbirth = permited.dateofbirth;
                    instasncestudent.gender = permited.gender;
                    instasncestudent.father = permited.father;
                    instasncestudent.username = permited.username;
                    instasncestudent.password = permited.password;
                    instasncestudent.bloodname = permited.bloodname;
                    instasncestudent.roleofpersons = permited.roleofpersons;

                    ///////////////// invitation message and making ticket :)

                    Random random_timefor_ticket = new Random();

                    instasncestudent.ticket = $"dear student your arrive time : {DateTime.Now.Year} / {DateTime.Now.Month} / {DateTime.Now.Day}" +
                        $" in =>{DateTime.Now.Hour} : {DateTime.Now.Minute + random_timefor_ticket.Next(10, 15)}";
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"invitation sent to ==> {instasncestudent.name}    \t{instasncestudent.familyname}    \t{instasncestudent.username}  " +
                        $"  \t{instasncestudent.ticket} \n");
                    Thread.Sleep(25);
                    Console.ResetColor();
                    studentss.Add(instasncestudent);
                }
            }
            Console.ResetColor();

        }

    }
}

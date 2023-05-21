using project_1_and_other_stuff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hogwartz_ahmad_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Permissible_Persons> people = new List<Permissible_Persons>();
            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Permissible_Persons Instance_person = new Permissible_Persons();
                    string[] human = ln.Split('\t').ToArray<string>();
                    Instance_person.name = human[0];
                    Instance_person.familyname = human[1];
                    Instance_person.dateofbirth = human[2];
                    Instance_person.gender = human[3];
                    Instance_person.father = human[4];
                    Instance_person.username = human[5];
                    Instance_person.password = human[6];
                    Instance_person.bloodname = (blood)Enum.Parse(typeof(blood), human[7].Replace(" ", ""), true);
                    Instance_person.roleofpersons = (role)Enum.Parse(typeof(role), human[8], true);
                    people.Add(Instance_person);
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
            while (true)
            {
                Cw.loading();
                Cw.Welcome_Hagwartz();
                Cw.WriteColor("[which user :] ", ConsoleColor.DarkRed);
                Cw.collumright();
                Cw.WriteColor("[Dumbeldore]      (1)" ,ConsoleColor.Green);
                Cw.collumright();
                Cw.WriteColor("[Teacher]      (2)", ConsoleColor.Green);
                Cw.collumright();
                Cw.WriteColor("[Student]      (3)", ConsoleColor.Green);
                Cw.collumright();
                Console.Write("your choice : ");
                int firstchoice = int.Parse(Console.ReadLine());
                Console.Clear();



                List<Student > students = new List<Student>(people.Count);
                

                switch (firstchoice)
                {
                    
                        case 1://Dumbeldore
                        {
                            Cw.loading();
                            bool dumbledore_choice_switch = true;
                            while (dumbledore_choice_switch)
                            {
                                Console.Clear();
                                Cw.Welcome_Hagwartz();
                                int choice_of_Dumbledore = Dumbledore.DisplayAction();
                                if (choice_of_Dumbledore == 1)
                                {
                                    Dumbledore.Sending_Invitation(people, students);

                                }
                                else if (choice_of_Dumbledore == 2)
                                {

                                }
                                else if (choice_of_Dumbledore == 3)
                                {

                                }
                                Cw.WriteColor("[master if you have more work to do press] (y) [otherwise] (N)", ConsoleColor.DarkRed);
                                string dumbledore_choice_switch_string = Console.ReadLine();
                                if(dumbledore_choice_switch_string == "N")
                                {
                                    dumbledore_choice_switch = false;
                                }
                            }
                            Console.Clear();
                            break;
                        }
                        case 2://Teacher
                        {




                            break;
                        }
                        case 3://Student
                        {



                            break;
                        }
                }
            }



        }
    }

}

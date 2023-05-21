using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace project_1_and_other_stuff
{
    internal class Cw
    {


        //Console.BackgroundColor = ConsoleColor.Blue;
        //Console.ForegroundColor = ConsoleColor.White;
        //Console.WriteLine("White on blue.");
        //Console.WriteLine("Another line.");
        //Console.ResetColor();
        static int counter;
        public Cw()
        {
            counter = 0;
        }




        // use   :    WriteColor("This is my [message] with inline [color] changes.", ConsoleColor.harrangi);

        public static void WriteColor(string message, ConsoleColor color)
        {
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }
        public static void collumright()
        {
            WriteColor("[________________________________________________]", ConsoleColor.DarkYellow);
        }
        public static void loading()
        {
            string loading = "loading...";
            if(Console.CursorTop!= 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            }
            for(int i=0 ; i < loading.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(loading[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(300);
            Console.ResetColor();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("                    ");
        }

        public static void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(300);
        }
        public static void Welcome_Hagwartz()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{DateTime.Now.Hour} : {DateTime.Now.Minute}");
            Console.ResetColor();
            Cw.WriteColor("_____________________[WELCOME    to    HAGWARTS]_____________________", ConsoleColor.DarkMagenta);
            Console.WriteLine("\n");
        }
     
        //public static void loadingsystem()
        //{
        //    int counter = 0;
        //    Console.BackgroundColor = ConsoleColor.DarkBlue;
        //    Console.SetCursorPosition(50, 20);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(49, 20);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(48, 20);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(47, 19);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(46, 19);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(45, 18);
        //    Console.Write(" ");
        //    Console.SetCursorPosition(45, 17);
        //    Console.Write(" ");
        //    Console.ResetColor();
        //}

    }
}

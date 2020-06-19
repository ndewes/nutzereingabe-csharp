using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char buchstabe1 = 'a';
            char buchstabe2 = 'a';
            Console.WriteLine((char)(buchstabe1 + buchstabe2));*/


            Console.WriteLine("Ich würde gerne dein Namen und dein Alter wissen.\n");

            Console.Write("Name:\t");
            string name = Console.ReadLine();

            Console.Write("Alter:\t");
            string alter = Console.ReadLine();

            //Alternative
            /*foreach (var item in alter)
            {
                Console.WriteLine("Buchstabe: " + item);
               if(!Char.IsDigit(item))
                {
                    Console.WriteLine("Etwas ist schief gelaufen...");
                    break;
                }
            }*/

            if (Byte.TryParse(alter, out byte result))
            {
                //Hier kommt man rein wenn es erfolgreich convertiert wurde..
                Console.WriteLine($"\nDein name ist {name}.");
                Console.WriteLine("Du bist " + result + " Jahre alt.");

                /*Console.WriteLine(String.Format("Du bist {0} Jahre alt. {0} {0}", result));

                Console.WriteLine($"Variable Alter Typ: {alter.GetType().Name}\nVariable result Typ: {result.GetType().Name}");

                Console.WriteLine(String.Format("Variable Alter Typ: {0}\nVariable result Ty p: {1}", alter.GetType().Name, result.GetType().Name));

                .WriteLine("Variable Alter Typ: " + alter.GetType().Name + "\nVariable result Typ: " + result.GetType().Name);*/
            }
            else
            {
                //Falls was schiefgelaufen ist....
                Console.WriteLine("Leider lief etwas schief... " + alter);
            }
        }
    }
}

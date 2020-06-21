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

            Console.WriteLine("Ich würde gerne dein Namen und dein Alter wissen.\n");

            Console.Write("Name:\t");
            string name = Console.ReadLine();

            Console.Write("Alter:\t");

            bool wartetAufNutzereingabe = true;

            do
            {
                string alter = Console.ReadLine();

                if (Byte.TryParse(alter, out byte result))
                {
                    Console.WriteLine($"\nDein name ist {name}.");
                    Console.WriteLine("Du bist " + result + " Jahre alt.");
                    wartetAufNutzereingabe = false;
                }
                else
                {
                    Console.WriteLine("Leider lief etwas schief... " + alter + "\n");
                    Console.WriteLine("Bitte gib dein alter in Zahlen ein!");
                    Console.Write("Alter:\t");
                }
            } while (wartetAufNutzereingabe);
        }
    }
}
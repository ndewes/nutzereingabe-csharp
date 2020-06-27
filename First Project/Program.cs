using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace First_Project
{
    class Program
    {
        private static Dictionary<string, string> dictionary = new Dictionary<string, string>() { };

        static void Main(string[] args)
        {
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
                    Console.WriteLine("Du bist " + result + " Jahre alt.\n");
                    wartetAufNutzereingabe = false;
                }
                else
                {
                    Console.WriteLine("Leider lief etwas schief... " + alter + "\n");
                    Console.WriteLine("Bitte gib dein alter in Zahlen ein!");
                    Console.Write("Alter:\t");
                }
            } while (wartetAufNutzereingabe);
            AbfrageNachInput("Würdest du mir deine Adresse verraten? [Ja/Nein]\n");


        }

        public static void AbfrageNachInput(string frage)
        {
            Console.Write(frage);
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "ja")
            {
                //Weiter mit der Adresse
                GetInput("In welcher Straße wohnst du: ", "Straße");
                GetInputZahlen("Welche Hausnummer hast du: ", "Hausnummer");
                GetInputZahlen("Welche PLZ hat dein Ort: ", "PLZ");
                GetInput("In welchem Ort wohnst du: ", "Ort");
                Console.WriteLine("Fertig! Ergebins:");
                GetErgebnis();
                return;
            }
            else if (userInput.ToLower() == "nein")
            {
                Console.WriteLine("Dann ein anderes mal...");
                return;
            }

            Console.WriteLine("Du hast eine falsche Eingabe getätigt.\nBitte Taste drücken...");
            Console.ReadKey();
            Console.Clear();
            AbfrageNachInput(frage);
        }

        private static void GetErgebnis()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Du wohnst in {item.Key}: {item.Value}");
            }
        }

        public static void GetInput(string frage, string dictionarytitel)
        {
            Console.Write(frage);
            var input = Console.ReadLine();
            dictionary.Add(dictionarytitel, input);
        }

        public static void GetInputZahlen(string frage, string dictionarytitel)
        {
            Console.Write(frage);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int result)) GetInputZahlen(frage, dictionarytitel);
            else
            {
                dictionary.Add(dictionarytitel, input);
            }
        }
    }
}
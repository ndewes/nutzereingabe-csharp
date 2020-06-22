using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace First_Project
{
    class Program
    {
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

            var dictionary = new Dictionary<string, string>(){};

            void adresse()
            {
                Console.Write("Würdest du mir deine Adresse verraten? [Ja/Nein]\n");
                string userInput = Console.ReadLine();
                if (userInput == "Ja" || userInput == "ja")
                {
                    //Weiter mit der Adresse
                    Console.Write("\nStraße: ");
                    dictionary.Add("Straße", Console.ReadLine());

                    Console.Write("Hausnummer: ");
                    hausnummer();

                }
                else if (userInput == "Nein" || userInput == "nein")
                {
                    Console.WriteLine("Dann ein anderes mal...");
                }
                else
                {
                    Console.WriteLine("Du hast eine falsche Eingabe getätigt.");
                    adresse();
                }
            }

            void hausnummer()
            {
                string hausnummer = Console.ReadLine();

                if (Byte.TryParse(hausnummer, out byte hn))
                {
                    dictionary.Add("Hausnummer", hausnummer);
                    Console.Write("Postleitzahl: ");
                    postleitzahl();
                }
                else
                {
                    Console.WriteLine("Leider ist etwas schief gelaufen... " + hausnummer);
                    Console.WriteLine("Bitte gib deine Hausnummer in Zahlen ein!");
                    Console.Write("Hausnummer:\t");
                }
            }

            void postleitzahl()
            {
                string postleitzahl = Console.ReadLine();

                if (int.TryParse(postleitzahl, out int plz))
                {
                    dictionary.Add("Postleitzahl", postleitzahl);
                    Console.Write("Ort: ");
                    ort();
                }
                else
                {
                    Console.WriteLine("Leider ist etwas schief gelaufen... " + postleitzahl);
                    Console.WriteLine("Bitte gib deine Postleitzahl in Zahlen ein!");
                    Console.Write("Postleitzahl:\t");
                }
            }
            void ort()
            {
                dictionary.Add("Ort", Console.ReadLine());
            }

            adresse();

            Console.WriteLine("\nDeine Adresse lautet: " );

            foreach(var adressTeil in dictionary)
            {
                Console.WriteLine(adressTeil.Value);
            }
        }
    }
}
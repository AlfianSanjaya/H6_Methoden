using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            int dood = 0;
            while (true)
            {
                bool heeftBloemen = false;
                string held = WelkomstScherm($"The Quest of Doom {dood}", ConsoleColor.Red);
                HuisScherm(heeftBloemen);
                GameOverScherm(held);
                dood++;
            }
            
        }

        static string WelkomstScherm(string titel, ConsoleColor kleurIn)
        {
            Console.ForegroundColor = kleurIn;
            Console.WriteLine(titel);
            Console.ResetColor();
            Console.WriteLine("Naam van je held");
            string naam = Console.ReadLine();
            return naam;
        }

        static void GameOverScherm(string naam)
        {
            Console.WriteLine(naam + ", Ge zijt dood!");
        }

        static void HuisScherm(bool heeftBloemen)
        {
            bool juisteKeuze = false;
            while (!juisteKeuze)
            {
                Console.WriteLine("Je staat in een huis.");
                Console.WriteLine("Je kan naar het oosten (o) of westen (w)");
                char keuze = Convert.ToChar(Console.ReadLine());
                if (keuze == 'o')
                {
                    TuinScherm(heeftBloemen);
                    juisteKeuze = true;
                }
                else if (keuze == 'w')
                {
                    StraatScherm();
                    juisteKeuze = true;
                }
                else
                {
                    Console.WriteLine("Foute keuze!");                    
                }
            }               
        }

        static void StraatScherm()
        {
            Console.WriteLine("Je staat op straat.");
        }

        static void TuinScherm(bool heeftBloemen)
        {
            Console.WriteLine("Je staat in de tuin.");
            if (!heeftBloemen)
            {
                Console.WriteLine("Wat een mooi bloempjes.");
                Console.WriteLine("Wil je naar het westen (w) of bloempjes plukken (p)?");               
            }
            else
            {
                Console.WriteLine("Wil je naar het westen (w)?");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class EenProgrammaSchrijvenInCSharp
    {

        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Oefening 1 - MijnEersteMethode");
            Console.WriteLine("2 - Oefening 2 - EersteProgramma");
            Console.WriteLine("3 - Oefening 3 - RommelZin");
            Console.WriteLine("4 - Oefening 4 - Gekleurderommelzin");

            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                EenProgrammaSchrijvenInCSharp.MijnEersteMethode();
            }

            else if (Oefening == 2)
            {
                EenProgrammaSchrijvenInCSharp.EersteProgramma();
            }

            else if (Oefening == 3)
            {
                EenProgrammaSchrijvenInCSharp.RommelZin();
            }

            else if(Oefening == 4)
            {
                EenProgrammaSchrijvenInCSharp.Gekleurderommelzin();
            }

            else
            {
                Console.WriteLine("Niet geldig");
            }
        }


        public static void MijnEersteMethode()
        {
            Console.WriteLine("Mijn eerste programma werkt!");
        }

        public static void EersteProgramma()
        {
            Console.WriteLine("Dit is mijn eerste programma!");
            Console.Write("*****************************");
            Console.WriteLine("Typ je voornaam: ");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Typ je achternaam: ");
            string achternaam = Console.ReadLine();



            Console.WriteLine($"dus je naam is: {voornaam + " " + achternaam} of: {achternaam + " " + voornaam}");
        }



        public static void RommelZin()
        {
            Console.WriteLine("Wat is je favoriete kleur? ");
            string FavoKleur = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete eten? ");
            string FavoFood = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete film? ");
            string FavoMovie = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete boek? ");
            string FavoBook = Console.ReadLine();



            Console.WriteLine($"Je favoriete kleur is {FavoKleur}. Je eet graag {FavoFood}. Je lievelingsfilm is {FavoMovie} en je favoriete boek is {FavoBook}");
        }


        public static void Gekleurderommelzin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wat is je favoriete kleur? ");
            Console.ResetColor();
            string FavoKleur = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wat is je favoriete eten? ");
            Console.ResetColor();
            string FavoFood = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wat is je favoriete film? ");
            Console.ResetColor();
            string FavoMovie = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Wat is je favoriete boek? ");
            Console.ResetColor();
            string FavoBook = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Je favoriete kleur is {FavoKleur}. Je eet graag {FavoFood}. Je lievelingsfilm is {FavoMovie} en je favoriete boek is {FavoBook}");






        }

    }
}

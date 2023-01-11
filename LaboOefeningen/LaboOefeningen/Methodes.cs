using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Methodes
    {

        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");

            Console.WriteLine("1 - Oefening 1 - ReeksOperaties");

            Console.WriteLine("2 - Oefening 2 - EmailGenerator");

            Console.WriteLine("3 - Oefening 2 - ReeksOperatiesMetReturn");


            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                Methodes.ReeksOperaties();
            }

            else if (Oefening == 2)
            {
                Methodes.EmailGenerator();
            }

            else if (Oefening == 3)
            {
                Methodes.ReeksOperatiesMetReturn();
            }
            else
            {
                Console.WriteLine("Niet geldig");
            }

        }

        public static void ReeksOperaties()
        {
            Console.Write("Geef de diameter van de cirkel: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            BerekenStraal(diameter);
            BerekenOmtrek(diameter);
            BerekenOppervlakte(diameter);

            Console.WriteLine("Geef twee getallen: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            double getal2 = Convert.ToDouble(Console.ReadLine());
            BerekenMaximum(getal1, getal2);

            Console.WriteLine("Geef een geheel getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            BerekenEvenOneven(getal);

            ReeksOneven(getal);

        }
        public static void BerekenStraal(double diameter)
        {

            Console.WriteLine($"De straal van de cirkel is {diameter / 2}");

        }

        public static void BerekenOmtrek(double diameter)
        {

            Console.WriteLine($"De omtrek van de cirkel is {Math.PI * diameter}");

        }

        public static void BerekenOppervlakte(double diameter)
        {

            Console.WriteLine($"De oppervlakte van de cirkel is {Math.PI * ((diameter / 2) * (diameter / 2))}");

        }



        public static void BerekenMaximum(double getal1, double getal2)
        {

            if (getal1 > getal2)
            {
                Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {getal1} ");

            }

            else
            {
                Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {getal2} ");
            }

        }

        public static void BerekenEvenOneven(int getal)
        {
            if (getal % 2 == 0)
            {
                Console.WriteLine($"Het getal {getal} is een even getal");



            }
            else
            {
                Console.WriteLine($"Het getal {getal} is een oneven getal");
            }


        }


        public static void ReeksOneven(int getal)
        {
            Console.WriteLine($"De reeks van oneven getallen van 1 tot {getal} is:");

            for (int i = 0; i <= getal; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write($"{i} ");
                }

            }


        }
        public static string MyToLower(string input)
        {

            string output = "";
            foreach (char character in input)
            {
                if (character >= 'A' && character >= 'Z')
                {
                    output = output + Convert.ToChar(character - 'A' + 'a');

                }

                else
                {
                    output = output + character;

                }
            }
            return output;

        }

        public static string RemoveSpaces(string input)
        {
            string output = "";
            foreach (char character in input)
            {
                if (character != ' ')
                {
                    output = output + character;
                }
            }
            return output;
        }

        public static void EmailGenerator()
        {
            string voornaam;
            string achternaam;
            bool isStudent;

            Console.WriteLine("Geef voornaam");
            voornaam = Console.ReadLine();

            Console.WriteLine("Geef achternaam");
            achternaam = Console.ReadLine();

            Console.WriteLine("Student? (true/false");

            isStudent = Convert.ToBoolean(Console.ReadLine());

            string GedeelteNaam = ($"{RemoveSpaces(MyToLower(voornaam))}.{RemoveSpaces(MyToLower(achternaam))}");


            if (isStudent)
            {
                Console.WriteLine($"{GedeelteNaam}@student.ap.be");
            }
            else
            {
                Console.WriteLine($"{GedeelteNaam}@ap.be");
            }



        }

        public static void ReeksOperatiesMetReturn()
        {
            Console.Write("Geef de diameter van de cirkel: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De straal van de cirkel is {BerekenStraalMetReturn(diameter):f3}");
            Console.WriteLine($"De omtrek van de cirkel is {BerekenOmtrekMetReturn(diameter):f3}");
            Console.WriteLine($"De straal van de cirkel is {BerekenOppervlakteMetReturn(diameter):f3}");
            Console.WriteLine("Geef twee getallen: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {MaximumMetReturn(getal1, getal2)}");
            Console.WriteLine("Geef een geheel getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (IsEvenMetReturn(getal))
            {
                Console.WriteLine($"Getal {getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"Getal {getal} is een oneven getal");
            }
            Console.WriteLine($"De reeks van oneven getallen van 1 tot {getal} is:");
            ToonOnevenNummersMetReturn(getal);
            Console.ReadKey();
        }
        public static double BerekenStraalMetReturn(double diameter)
        {
            return Math.Round(diameter / 2, 3);

        }
        public static double BerekenOmtrekMetReturn(double diameter)
        {
            return Math.Round(diameter * Math.PI, 3);
        }
        public static double BerekenOppervlakteMetReturn(double diameter)
        {
            return BerekenStraalMetReturn(diameter) * BerekenStraalMetReturn(diameter) * Math.PI;
        }
        public static double MaximumMetReturn(double getal1, double getal2)
        {
            if (getal1 >= getal2)
            {
                return getal1;
            }
            else
            {
                return getal2;
            }
        }
        public static bool IsEvenMetReturn(int getal)
        {
            if (getal % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ToonOnevenNummersMetReturn(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }




    }

}




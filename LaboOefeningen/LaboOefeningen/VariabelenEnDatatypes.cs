using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{

    internal class VariabelenEnDatatypes
    {

        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");


            Console.WriteLine("1 - Oefening 1 - BeetjeWiskunde");
            Console.WriteLine("2 - Oefening 2 - EersteProgramma");
            Console.WriteLine("3 - Oefening 3 - Optellen");
            Console.WriteLine("4 - Oefening 4 - Verbruikwagen");
            Console.WriteLine("5 - Oefening 5 - Maaltafels");
            Console.WriteLine("6 - Oefening 6 - Ruimte");




            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                VariabelenEnDatatypes.BeetjeWiskunde();
            }

            else if (Oefening == 2)
            {
                VariabelenEnDatatypes.Gemiddelde();
            }

            else if (Oefening == 3)
            {
                VariabelenEnDatatypes.Optellen();
            }

            else if (Oefening == 4)
            {
                VariabelenEnDatatypes.Verbruikwagen();
            }


            else if (Oefening == 5)
            {
                VariabelenEnDatatypes.Maaltafels();
            }


            else if(Oefening == 6)
            {
                VariabelenEnDatatypes.Ruimte();
            }

            else
            {
                Console.WriteLine("Niet geldig");
            }

        }
        public static void BeetjeWiskunde()
        {
            int a = -1 + 4 * 6;
            int b = (35 + 5) * 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 * 2;



            Console.WriteLine(a);
        }


        public static void Gemiddelde()
        {

            int a = 18;
            int b = 11;
            int c = 8;

            Console.WriteLine((a + b + c)/ 3);




        }

        public static void Optellen()
        {

            Console.WriteLine("Wat is je eerste getal?");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"De som is {getal1 + getal2}.");




        }

        public static void Verbruikwagen()
        {
            Console.WriteLine("Geef het aantal liter in de tank voor de rit:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef het aantal liter in de tank na de rit:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef de kilometerstand van je auto voor de rit:");
            double number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef de kilometerstand van je auto na de rit:");
            double number4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Het verbruik van de auto is {100 * (number1 - number2) / (number4 - number3)}");



        }


        public static void Maaltafels()
        {
            int a = 1 * 411;

            int b = 2 * 411;

            int c = 3 * 411;

            int d = 4 * 411;

            int e = 5 * 411;

            int f = 6 * 411;

            int g = 7 * 411;

            int h = 8  * 411;

            int i = 9 * 411;

            int j = 10 * 411;

            Console.WriteLine($"1 * 411 is {a}");
            Console.WriteLine($"2 * 411 is {b}");
            Console.WriteLine($"3 * 411 is {c}");
            Console.WriteLine($"4 * 411 is {d}");
            Console.WriteLine($"5 * 411 is {e}");
            Console.WriteLine($"6 * 411 is {f}");
            Console.WriteLine($"7 * 411 is {g}");
            Console.WriteLine($"8 * 411 is {h}");
            Console.WriteLine($"9 * 411 is {i}");
            Console.WriteLine($"10 * 411 is {j}");


        }



        public static void Ruimte()
        {
            Console.WriteLine("Hoeveel weeg je?");
            double gewichtpersoon = Convert.ToDouble(Console.ReadLine());
           



            Console.WriteLine($"Op Mercurius voel je je alsof je {gewichtpersoon * 0.38}kg weegt.");
            Console.WriteLine($"Op Venus voel je je alsof je {gewichtpersoon * 0.91}kg weegt.");
            Console.WriteLine($"Op Aarde voel je je alsof je {gewichtpersoon * 1}kg weegt.");
            Console.WriteLine($"Op Mars voel je je alsof je {gewichtpersoon * 0.38}kg weegt.");
            Console.WriteLine($"Op Jupiter voel je je alsof je {gewichtpersoon * 2.34}kg weegt.");
            Console.WriteLine($"Op Saturnus voel je je alsof je {gewichtpersoon * 1.06}kg weegt.");
            Console.WriteLine($"Op Uranus voel je je alsof je {gewichtpersoon * 0.92}kg weegt.");
            Console.WriteLine($"Op Neptunus voel je je alsof je {gewichtpersoon * 1.19}kg weegt.");
            Console.WriteLine($"Op Pluto voel je je alsof je {gewichtpersoon * 0.06}kg weegt.");




        }
    }
}

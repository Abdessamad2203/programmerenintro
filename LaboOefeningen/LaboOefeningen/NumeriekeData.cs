using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class NumeriekeData
    {

        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");

            Console.WriteLine("1 - Oefening 1 - LengteOppervlakteVolume");

            Console.WriteLine("2 - Oefening 2 - schaar-steen-papier");

            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                NumeriekeData.LengteOppervlakteVolume();
            }

            else if (Oefening == 2)
            {
                NumeriekeData.SchaarSteenPapier();
            }
        }


        public static void LengteOppervlakteVolume()
        {
            Console.WriteLine("Hoe lang is de zijde in meter?");
            double getalZijde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De lengte is: {getalZijde}");
            Console.WriteLine($"De oppervlakte is: {Math.Pow(getalZijde, 2)}m²");
            Console.WriteLine($"Het volume is: {Math.Pow(getalZijde, 3)}m³");
        }

        public static void SchaarSteenPapier()
        {


            int schaar = 1;
            int steen = 2;
            int papier = 3;




            int HumanScore = 0;
            int ComputerScore = 0;

            Random randomgen = new Random();


            while (HumanScore != 10 && ComputerScore != 10)
            {
                Console.WriteLine("Maak een keuze: ");

                Console.Write("1 voor schaar");
                Console.Write("2 voor steen");
                Console.Write("3 voor papier");



                int HumanGetal = Convert.ToInt32(Console.ReadLine());



                int ComputerGetal = randomgen.Next(1, 4);


                if (ComputerGetal == 1 && HumanGetal == 1)
                {
                    Console.WriteLine($"De computer kiest schaar!");
                    Console.WriteLine("Niemand wint deze ronde!");
                }
                else if (ComputerGetal == 2 && HumanGetal == 2)
                {
                    Console.WriteLine($"De computer kiest steen!");
                    Console.WriteLine("Niemand wint deze ronde!");

                }

                else if (ComputerGetal == 3 && HumanGetal == 3)
                {
                    Console.WriteLine($"De computer kiest papier!");
                    Console.WriteLine("Niemand wint deze ronde!");

                }
                else if (ComputerGetal == 3 && HumanGetal == 1)
                {
                    Console.WriteLine("De computer kiest papier!");
                    Console.WriteLine("Jij wint deze ronde!");
                    HumanScore++;
                    Console.WriteLine($"Jij hebt {HumanScore}punt, de computer heeft {ComputerScore} punten.");

                }
                else if (HumanGetal == 1 && ComputerGetal == 2)
                {
                    Console.WriteLine("De computer kiest steen!");
                    Console.WriteLine("Jij wint deze ronde!");
                    ComputerScore++;
                    Console.WriteLine($"Jij hebt {HumanScore}punt, de computer heeft {ComputerScore} punten.");

                }
            }
            if (HumanScore == 10)
            {
                Console.WriteLine($"Jij hebt {HumanScore} punten, de computer heeft {ComputerScore}.");

                Console.WriteLine("Je hebt gewonnen!");

            }
            else
            {
                Console.WriteLine($"Jij hebt {HumanScore} punten, de computer heeft {ComputerScore}.");

                Console.WriteLine("De computer is gewonnen!");

            }
        }
    }
}

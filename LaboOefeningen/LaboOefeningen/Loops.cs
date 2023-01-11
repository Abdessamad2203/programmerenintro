using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Loops
    {
        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Oefening 1 - CountDown");
            Console.WriteLine("2 - Oefening 2 - Wachtwoord");
            Console.WriteLine("3 - Oefening 3 - Gemiddelde");
            Console.WriteLine("4 - Oefening 4 - Feestje");
            Console.WriteLine("5 - Oefening 5 - AantalDigits");
            Console.WriteLine("6 - Oefening 6 - VanMin100Tot100");
            Console.WriteLine("7 - Oefening 7 - EenTafel");
            Console.WriteLine("8 - Oefening 8 - Veelvouden6En8");
            Console.WriteLine("9 - Oefening 9 - PriemChecker");
            Console.WriteLine("10 - Oefening 10 - Factoren");



            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                Loops.CountDown();
            }

            else if (Oefening == 2)
            {
                Loops.Wachtwoord();
            }

            else if (Oefening == 3)
            {
                Loops.Gemiddelde();
            }

            else if (Oefening == 4)
            {
                Loops.Feestje();
            }


            else if (Oefening == 5)
            {
                Loops.AantalDigits();

            }

            else if (Oefening == 6)
            {
                Loops.VanMin100Tot100();

            }

            else if (Oefening == 7)
            {
                Loops.EenTafel();

            }

            else if (Oefening == 8)
            {
                Loops.Veelvouden6En8();

            }

            else if (Oefening == 9)
            {
                Loops.PriemChecker();

            }


            else if (Oefening == 10)
            {
                Loops.Factoren();

            }


            else
            {
                Console.WriteLine("Niet geldig");
            }
        }

        public static void CountDown()
        {

            Console.Write("Geef een getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            while (getal > 0)
            {
                Console.WriteLine(getal);
                getal = getal - 1;


            }


            Console.WriteLine("Start!");
        }



        public static void Wachtwoord()
        {
            string PSW = "AP";
            int aantal = 0;
            string wachtwoord;
            do
            {
                Console.WriteLine("Geef het wachtwoord in:");
                wachtwoord = Console.ReadLine();
                aantal = aantal + 1;


            } while (wachtwoord != PSW);

            Console.WriteLine("Wachtwoord in orde!");
            Console.WriteLine("aantal pogingen: " + aantal);





        }

        public static void Gemiddelde()
        {
            int getal;
            int aantal = 0;
            double optelling = 0;
            do
            {
                Console.Write("Geef het volgende getal in (stoppen met 0)");
                getal = Convert.ToInt32(Console.ReadLine());

                optelling += getal;
                aantal++;

            } while (getal != 0);


            Console.WriteLine($"Het gemiddelde: {optelling / (aantal - 1)}");


        }

        public static void Feestje()
        {
            string Persoon;
            int aantal = 0;
            while (aantal <= 20)
            {
                Console.WriteLine("Wil je een volgende persoon inschrijven? (ja of nee) ");
                Console.Write("Geef de naam: ");
                Persoon = Console.ReadLine();


            }




        }

        public static void AantalDigits()
        {
            Console.WriteLine("Geef een geheel getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            int aantal = 0;

            do
            {
                getal = getal / 10;
                aantal++;


            } while (getal != 0);

            Console.WriteLine($"Het ingegeven getal bestaat uit {aantal} cijfers");


        }

        public static void VanMin100Tot100()
        {

            for (int i = -100; i <= 100; i++)
            {
                Console.WriteLine(i++);
            }




        }


        public static void EenTafel()
        {
            Console.WriteLine("Van welk getal wil je de tafel van vermenigvuldiging zien?");
            int tafel = Convert.ToInt32(Console.ReadLine());

            for (int i = 5; i <= 10; i++)
            {
                int uitkomst = tafel * i;

                Console.WriteLine($"{tafel} x {i} is {uitkomst}");
            }




        }

        public static void Veelvouden6En8()
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 6==0 || i % 8 ==0))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        public static void PriemChecker()
        {

            Console.WriteLine("Geef een getal in:");
            int number = Convert.ToInt32(Console.ReadLine());

            int numberOfDivisers = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {

                    if (number % i == 0)
                    {
                        numberOfDivisers++;
                    }
                }
                    if (numberOfDivisers == 2)
                    {
                        Console.WriteLine("PriemGetal");
                    }

                    else
                    {                        
                        Console.WriteLine("Geen PriemGetal");
                    }

                
            }



        }



        public static void Factoren()
        {
            Console.WriteLine("Geef een getal (groter dan 1)");
            int number =Convert.ToInt32(Console.ReadLine());
            int Divider = 1 ;
            while (Divider <= number)
            {
                if (number % Divider == 0)
                {
                    int factoren = number / Divider;
                    
                        Console.WriteLine($"factoren zijn {factoren}");

                    
                } 
                
                Divider++;
                




            }



        }
    }


}

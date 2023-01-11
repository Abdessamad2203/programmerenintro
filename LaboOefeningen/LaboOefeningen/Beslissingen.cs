using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Beslissingen
    {
        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");

            Console.WriteLine("1 - Oefening 1 - SchoenenVerkoper");
            Console.WriteLine("2 - Oefening 2 - EvenOneven");
            Console.WriteLine("3 - Oefening 3 - PositiefNegatiefNul");
            Console.WriteLine("4 - Oefening 4 - BMIBerekenaar");
            Console.WriteLine("5 - Oefening 5 - GrootsteVanDrie");
            Console.WriteLine("6 - Oefening 6 - Examens");
            Console.WriteLine("7 - Oefening 7 - WetVanOhm");



            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                Beslissingen.SchoenenVerkoper();
            }

            else if (Oefening == 2)
            {
                Beslissingen.EvenOneven();
            }

            else if (Oefening == 3)
            {
                Beslissingen.PositiefNegatiefNul();
            }

            else if (Oefening == 4)
            {
                Beslissingen.BMIBerekenaar();
            }


            else if (Oefening == 5)
            {
                Beslissingen.GrootsteVanDrie();
            }


            else if (Oefening == 6)
            {
                Beslissingen.Examens();
            }

            else if(Oefening == 7)
            {
                Beslissingen.WetVanOhm();
            }

            else
            {
                Console.WriteLine("Niet geldig");
            }


        }
        public static void SchoenenVerkoper()
        {
            double prijs = 50;
           

            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int aantal = Convert.ToInt32( Console.ReadLine());
            prijs = prijs * aantal;
            if (aantal >= 2)
            {
                prijs = prijs - prijs * 0.10;
            }


            Console.WriteLine($"De prijs voor {aantal} paar schoenen is {prijs} euro");

        }

        public static void EvenOneven (){

            
            Console.WriteLine("Geef een getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal%2==0)
            {
                Console.WriteLine($"Het getal {getal} is even");



            }
            else
            {
                Console.WriteLine($"Het getal {getal} is oneven");
            }

            
        
        }
        public static void PositiefNegatiefNul()
        {

            Console.WriteLine("Geef een getal:");
            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal > 0)
            {
                Console.WriteLine($"Het getal {getal} is positief");

            }
            else if (getal < 0)
            {
                Console.WriteLine($"Het getal {getal} is negatief");

            }
            else
            {
                Console.WriteLine("Het getal is NUL.");
            }




        }

        public static void BMIBerekenaar()
        {


            Console.WriteLine("Wat is je gewicht?");
            
            int gewicht = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Wat is je lengte?");

            double length = Convert.ToDouble(Console.ReadLine());

            double BMI = Math.Round( gewicht / (length * length), 1);

            if (BMI < 18.5)
            {
                Console.WriteLine($"Je hebt een BMI van {BMI}. Je hebt ondergewicht");
            }
            else if (BMI == 18.5 || BMI < 25)
            {
                Console.WriteLine($"Je hebt een BMI van {BMI}. Je hebt normaal gewicht");


            }
            else if (BMI == 25 || BMI < 30)
            {
                Console.WriteLine($"Je hebt een BMI van {BMI}. Je hebt overgewicht");

            }
            else if (BMI == 30 || BMI < 40)
            {
                Console.WriteLine($"Je hebt een BMI van {BMI}. Je hebt zwaarlijvig");

            }

            else if (BMI > 40)
            {
                Console.WriteLine($"Je hebt een BMI van {BMI}. Je hebt ernstige obesitas");
                
            }


        }


        public static void GrootsteVanDrie()
        {
            Console.WriteLine("Geeft het eerste getal in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geeft het tweede getal in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geeft het derde getal in: ");
            int getal3 = Convert.ToInt32(Console.ReadLine());

            if (getal1 >= getal2 && getal1 >= getal3)
            {
                Console.WriteLine($"Het eerste getal {getal1} is het grootste");

            }

            else if (getal2 >= getal1 && getal2 >= getal3)
            {
                Console.WriteLine($"Het tweede getal {getal2} is het grootste");


            }

            else
            {
                Console.WriteLine($"Het derde getal {getal3} is het grootste");

            }




        }

        public static void Examens()
        {
            Console.WriteLine("Geef het resultaat in van het eerste examen: ");
            int resultaat1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geef het resultaat in van het tweede examen: ");
            int resultaat2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Geef het resultaat in van het derde examen: ");
            int resultaat3 = Convert.ToInt32(Console.ReadLine());

            int gemiddelde = ((resultaat1 + resultaat2 + resultaat3) / 3);

            if (gemiddelde > 0.5)
            {

                Console.WriteLine("Je bent niet geslaagd");

            }

            else
            {
                Console.WriteLine("Je bent geslaagd");

            }


        }

        public static void WetVanOhm()
        {
            Console.WriteLine("Wat wil je berekenen: spanning, weerstand of stroomsterkte?");
            string keuze = Console.ReadLine();


            if (keuze == "spanning")
            {

                Console.WriteLine("Wat is de weerstand?");
                double weerstand = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                Console.WriteLine("Wat is de stroomsterkte?");

                double stroomsterkte = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                double Spanning = stroomsterkte * weerstand;
                Console.WriteLine($"De spanning is {Spanning}");

            }


            else if (keuze == "weerstand")
            {

                Console.WriteLine("Wat is de spanning?");
                double spanning = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                Console.WriteLine("Wat is de stroomsterkte?");

                double stroomsterkte = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                double Weerstand = spanning / stroomsterkte;

                Console.WriteLine($"De spanning is {Weerstand}");

            }

            else
            {

                Console.WriteLine("Wat is de weerstand?");
                double weerstand = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                Console.WriteLine("Wat is de spanning?");

                double spanning = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                double Stroomsterkte = spanning / weerstand;

                Console.WriteLine($"De spanning is {Stroomsterkte}");

            }










        }





    }
}

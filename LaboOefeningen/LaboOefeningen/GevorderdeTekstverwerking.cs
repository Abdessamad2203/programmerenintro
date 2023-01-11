using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{

    internal class GevorderdeTekstverwerking
    {
        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - SomVanGetallen");
            Console.WriteLine("2 - CentraalAlignerenTekst");
            Console.WriteLine("3 - kerstinkopenlist");

            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1) { GevorderdeTekstverwerking.SomVanGetallen(); }
            else if (menu == 2) { GevorderdeTekstverwerking.CentraalAlignerenTekst(); }
            else if (menu == 3) { GevorderdeTekstverwerking.KerstinkopenList(); }

        }
        public static void SomVanGetallen()
        {
            Console.WriteLine("Gelieve getallen gescheiden door ';'in te geven");
            string tekst = Console.ReadLine();
            string[] individualNumbers = Numbers.Split(";");
            int som = 0;
            string lijst = "";
            foreach (string individualNumber in individualNumbers)
            {
                som += Convert.ToInt32(individualNumber);
            }
            Console.WriteLine(string.Join());

        }
    
        public static void CentraalAlignerenTekst()
        {
            Console.WriteLine("Geef een tekst in:");
            string tekst = Console.ReadLine();
            Console.WriteLine("Geef een gewenste lengte van de tekst op, die moet minimaal 6 zijn");
            int lengte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef het padding 'padding karakter':");
            string paddingkarakter = Console.ReadLine();
            Console.WriteLine(CentraalAligneren(tekst, lengte, paddingkarakter));
        }
        public static string CentraalAligneren(string tekst, int lengte, string paddingkarakter)
        {
            int whitespace = lengte - tekst.Length;
            tekst = tekst.PadLeft(tekst.Length + whitespace / 2, Convert.ToChar(paddingkarakter)).PadRight(tekst.Length + whitespace / 2, Convert.ToChar(paddingkarakter));

            return tekst;
        }
        public static void KerstinkopenList()
        {
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            int numberOfPresents = Convert.ToInt32(Console.ReadLine());
            double[] presents = new double[numberOfPresents];
            for (int i = 0; i < numberOfPresents; i++)
            {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");
                presents[i] = Convert.ToDouble(Console.ReadLine());
                if (presents.Sum() > budget)
                {
                    Console.WriteLine($"Je bent al {(presents.Sum() - budget)} euro over het budget!");
                }
            }
            Console.WriteLine("Info over je aankopen: ");
            Console.WriteLine("".PadLeft(22, '='));
            Console.WriteLine($"{"Totaal bedrag: ",-25}{presents.Sum():C}");
            Console.WriteLine($"{"Duurste cadeau:",-25} {presents.Max():C}");
            Console.WriteLine($"{"Goedkoopste cadeau:",-25} {presents.Min():C}");
            Console.WriteLine($"{"Gemiddelde prijs:",-25} {presents.Average():C}");
        }
    }
}

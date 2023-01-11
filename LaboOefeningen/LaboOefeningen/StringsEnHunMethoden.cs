using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class StringsEnHunMethoden
    {

        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");


            Console.WriteLine("1 - Oefening 1 - VariabelenEnHoofdletters");
            Console.WriteLine("2 - Oefening 2 - MaaltafelsStringInterpolatie");
            Console.WriteLine("3 - Oefening 3 - RuimteStringInterpolatie");
            Console.WriteLine("4 - Oefening 4 - BerekenBtw");
            Console.WriteLine("5 - Oefening 5 - LeetSpeak");
            Console.WriteLine("6 - Oefening 6 - Instructies");
            Console.WriteLine("7 - Oefening 7 - Lotto");
            Console.WriteLine("8 - Oefening 8 - SomVanCijfers");
            Console.WriteLine("9 - Oefening 9 - NaamUitEmail");
            Console.WriteLine("10 - Oefening 10 - EersteLetterEnAchternaam");
            Console.WriteLine("11 - Oefening 11 - Toegangscode");


            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                StringsEnHunMethoden.VariabelenEnHoofdletters();
            }

            else if (Oefening == 2)
            {
                StringsEnHunMethoden.MaaltafelsStringInterpolatie();
            }

            else if (Oefening == 3)
            {
                StringsEnHunMethoden.RuimteStringInterpolatie();
            }

            else if (Oefening == 4)
            {
                StringsEnHunMethoden.BerekenBtw();
            }


            else if (Oefening == 5)
            {
                StringsEnHunMethoden.LeetSpeak();
            }


            else if (Oefening == 6)
            {
                StringsEnHunMethoden.Instructies();
            }

            else if (Oefening == 7)
            {
                StringsEnHunMethoden.Lotto();
            }

            else if (Oefening == 8)
            {
                StringsEnHunMethoden.SomVanCijfers();
            }


            else if (Oefening == 9)
            {
                StringsEnHunMethoden.NaamUitEmail();
            }


            else if (Oefening == 10)
            {
                StringsEnHunMethoden.EersteLetterEnAchternaam();
            }


            else if(Oefening == 11)
            {
                StringsEnHunMethoden.Toegangscode();
            }

            else
            {
                Console.WriteLine("Niet geldig");
            }
        }
        public static void VariabelenEnHoofdletters()
        {
            Console.WriteLine(" welke tekst moet ik omzetten?");
            string tekst = Console.ReadLine();

            Console.WriteLine($"{tekst.ToUpper()}");

        }


        public static void MaaltafelsStringInterpolatie()
        {
            //kan ik al

        }

        public static void RuimteStringInterpolatie()
        {
            //kan ik al

        }

        public static void BerekenBtw()
        {
            Console.WriteLine("Geef het bedrag in: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef BTW percentage in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int getal3 = ((getal / 100) * getal2) + getal;
            Console.WriteLine($"Het bedrag {getal} met {getal2}% btw bedraagt {getal3} ");

        }



        public static void LeetSpeak() {

            Console.WriteLine("Geef je tekst in: ");
            string tekst = Console.ReadLine().Replace("a", "@").Replace(" ", "");
            Console.WriteLine(tekst);

        
        
        
        
        
        
        }


        public static void Instructies()
        {
            Console.WriteLine("Wat is je naam?");
            string Naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            string Cursus = Console.ReadLine();
            Console.WriteLine($"Maak een map als volgt:/home/{Naam.Substring(0, 3)}/{Cursus}");

        }

        public static void Lotto()
        {
            Console.WriteLine("Wat zijn je cijfers (tussen 01 en 45)?");
            string randomgetallen = Console.ReadLine().Replace("," , "|");
            string lotto1 = randomgetallen.Substring(0,8);
            string lotto2 = randomgetallen.Substring(9);
            Console.WriteLine($"Je cijfers zijn:");
            Console.WriteLine(lotto1);
            Console.WriteLine(lotto2);



        }

        public static void SomVanCijfers()
        {

            Console.WriteLine("Gelieve een getal in te voeren dat bestaat uit exact 5 decimale cijfers.");
            string getal = Console.ReadLine();
            int getal1 = Convert.ToInt32(getal.Substring(0,1));
            int getal2 = Convert.ToInt32(getal.Substring(1,1));
            int getal3 = Convert.ToInt32(getal.Substring(2,1));
            int getal4 = Convert.ToInt32(getal.Substring(3,1));
            int getal5 = Convert.ToInt32(getal.Substring(4,1));


            Console.WriteLine($"De som is {Convert.ToInt32(getal1 + getal2 + getal3 + getal4 + getal5)}");

        }
        
        public static void NaamUitEmail()
        {
            Console.WriteLine("Geef je e-mailadres:");
            string email = Console.ReadLine();
            Console.WriteLine($"Je naam uit je e-mail is: {email.Substring(0,16).ToUpper()}");



        }


        public static void EersteLetterEnAchternaam()
        {
            Console.WriteLine("Geef je naam:");
            string Naam = Console.ReadLine();
            Console.WriteLine($"De eerste letter van je naam is: {Naam.Substring(0, 1)}");
            Console.WriteLine($"Je achternaam is: {Naam.Substring(4)}");


        }



        public static void Toegangscode()
        {
            Console.Write("Geef je naam:");
            string naam = Console.ReadLine();
            string naam1 = naam.Substring(6,1).ToLower();
            Console.Write("");
            string naam2 = naam.Substring(7,1).ToUpper(); 

            Console.Write("Geef je geboortejaar:");
            string jaar = Console.ReadLine().Substring(3,1);
            Console.Write("Geef je postbode:");
            double postcode = Convert.ToInt32(Console.ReadLine().Substring(0,1));

            Console.WriteLine($"Je toegangscode is {naam1+naam2+jaar+(postcode*postcode)}");

        }

    }
}

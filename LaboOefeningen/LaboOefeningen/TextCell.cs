using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class TextCell
    {

        public static string GetalVoorstellingNaarLetters(int getal)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int aantalSymbolen = alfabet.Length;
            string resultaat = "";
            int resterend = getal;
            bool laatsteKeer = false;
            while (!laatsteKeer)
            {
                if (resterend <= aantalSymbolen)
                {
                    laatsteKeer = true;
                }
                int karakterIndex = (resterend - 1) % aantalSymbolen;
                resultaat = alfabet[karakterIndex] + resultaat;
                resterend = (resterend - 1) / aantalSymbolen;
            }
            return resultaat;
        }



        public static int LetterVoorstellingNaarGetal(string letters)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int aantalSymbolen = alfabet.Length;
            int resultaat = 0;
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                int exponent = letters.Length - i - 1;
                resultaat += (alfabet.IndexOf(letters[i]) + 1) * (int)Math.Pow(aantalSymbolen, exponent);
            }
            return resultaat;
        }


        public static void TextCellMain()
        {
            Console.WriteLine("Hoe veel cellen telt je spreadsheet?");

            int aantalCellen = Convert.ToInt32(Console.ReadLine());

            string[] rooster = new string[aantalCellen];

            for (int i = 0; i < aantalCellen; i++)
            {
                rooster[i] = "";
            }
            while (true)
            {
                BerekenEnToonrooster(rooster);
                WijzigCel(rooster);
            }



        }
   public static void KopieerCellenZonderFormule(string[] roosterIn, string[] roosterUit )
        {

            for (int cel = 0; cel < roosterIn.Length; cel++)
            {
                if (!roosterIn[cel].StartsWith("="))
                {
                    roosterUit[cel] = roosterIn[cel];
                }
            }

        }

        public static bool BevatNulWaarden(string[] rooster)
        {
            for (int i = 0; i < rooster.Length; i++)
            {
                if (rooster[i] is null)
                {

                    return true;


                }
            }
            return false;
        }

        public static void BerekenOntbrekendeWaardenEenKeer(string[] rooster, string[] berekendRooster)
        {
            for (int cel = 0; cel < rooster.Length; cel++)
            {
                if (berekendRooster[cel] is null)
                {
                    berekendRooster[cel] = BerekenOntbrekendeCelRechtstreeks(rooster[cel].Substring(1), berekendRooster);
                }
            }
        }

        public static string WaardeVanCel(string waarde, string[] rooster)
        {
            if (IsGetal(waarde))
            {
                return waarde;
            }
            else
            {
                return rooster[LetterVoorstellingNaarGetal(waarde) - 1];
            }
        }
        public static string BerekenOntbrekendeCelRechtstreeks(string formule, string[] berekendRooster)
        {
            string[] somOnderdelen = formule.Split('+');
            for (int i = 0; i < somOnderdelen.Length; i++)
            {
                somOnderdelen[i] = WaardeVanCel(somOnderdelen[i], berekendRooster);
                if (somOnderdelen[i] is null)
                {
                    return null;
                }
            }
            int som = 0;
            for (int somOperand = 0; somOperand < somOnderdelen.Length; somOperand++)
            {
                som += Convert.ToInt32(somOnderdelen[somOperand]);
            }
            return som.ToString();
        }


        public static bool IsGetal(string voorstelling)
        {
            return voorstelling.StartsWith("0") ||
                   voorstelling.StartsWith("1") ||
                   voorstelling.StartsWith("2") ||
                   voorstelling.StartsWith("3") ||
                   voorstelling.StartsWith("4") ||
                   voorstelling.StartsWith("5") ||
                   voorstelling.StartsWith("6") ||
                   voorstelling.StartsWith("7") ||
                   voorstelling.StartsWith("8") ||
                   voorstelling.StartsWith("9");
        }
        public static void BerekenEnToonrooster(string[] rooster)
        {

            string[] berekendRooster = new string[rooster.Length];
            KopieerCellenZonderFormule(rooster, berekendRooster);

            while (BevatNulWaarden(berekendRooster))
            {
                BerekenOntbrekendeWaardenEenKeer(rooster, berekendRooster);
            }


            for (int i = 0; i < rooster.Length; i++)
            {

                Console.Write($"|{GetalVoorstellingNaarLetters(i+1).PadRight(10).Substring(0,10)}");

            }
            Console.WriteLine("|");
            for (int i = 0; i < rooster.Length; i++)
            {
                Console.Write($"{rooster[i].PadRight(10).Substring(0,10)}");
            }
            Console.WriteLine("|");


        }
        public static void WijzigCel(string[] rooster)
        {
            Console.WriteLine("Welke cel wil je wijzigen?");

            int celindex = LetterVoorstellingNaarGetal(Console.ReadLine()) - 1;

            Console.WriteLine("Wat wil je hier invullen?");

            rooster[celindex] = Console.ReadLine();


        }
    
    
    
    }

}

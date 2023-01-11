using System;
using System.Security.Cryptography.X509Certificates;

namespace LaboOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke hoofdstuk kies je?");
            Console.WriteLine("1 - Hoofdstuk 1 - Een programma schrijven in C#");
            Console.WriteLine("2 - Hoofdstuk 2 - Variabelen en datatypes");
            Console.WriteLine("3 - Hoofdstuk 3 - Strings en hun methoden");
            Console.WriteLine("4 - Hoofdstuk 4 - Beslissingen");
            Console.WriteLine("5 - Hoofdstuk 5 - Loops");
            Console.WriteLine("6 - Hoofdstuk 6 - Arrays");
            Console.WriteLine("7 - Hoofdstuk 7 - Methodes");
            Console.WriteLine("8 - Hoofdstuk 8 - Numerieke data");
            Console.WriteLine("9 - Hoofdstuk 9 - Meerdimensionaal");
            Console.WriteLine("10 - Hoofdstuk 10 - GevordeTekstVerwerking");
            Console.WriteLine("00 - TextCell");




            int Hoofdstuk = Convert.ToInt32(Console.ReadLine());


            if (Hoofdstuk == 1)
            {
                EenProgrammaSchrijvenInCSharp.KeuzeMenu();
            }

            else if (Hoofdstuk == 2)
            {
                VariabelenEnDatatypes.KeuzeMenu();
            }

            else if (Hoofdstuk == 3)
            {
                StringsEnHunMethoden.KeuzeMenu();
            }

            else if(Hoofdstuk == 4)
            {
                Beslissingen.KeuzeMenu();
            }

            else if (Hoofdstuk == 5)
            {
                Loops.KeuzeMenu();
            }



            else if (Hoofdstuk == 6)
            {
                Arrays.KeuzeMenu();

            }


            else if (Hoofdstuk == 7)
            {
                Methodes.KeuzeMenu();
            }

            else if (Hoofdstuk == 8)
            {
                NumeriekeData.KeuzeMenu();
            }

            else if (Hoofdstuk == 9)
            {
                Meerdimensionaal.KeuzeMenu();
            }

            else if (Hoofdstuk == 10)
            {
                GevorderdeTekstverwerking.KeuzeMenu();
            }


            else if (Hoofdstuk == 00)
            {
                TextCell.TextCellMain();
            }


            else
            {
                Console.WriteLine("Niet geldig");
            }





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class Meerdimensionaal
    {
        public static void KeuzeMenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1 - Oefening 1 - SomNdeRij");
            Console.WriteLine("2 - Oefening 2 - SomPerRij");
            Console.WriteLine("3 - Oefening 3 - Pixels");

            int Oefening = Convert.ToInt32(Console.ReadLine());

            if (Oefening == 1)
            {
                double[,] numbers = {{4.2, 8.1, 3.3},
                     {2.0, 4.0, 6.0},
                     {3.1,3.2,3.3}};
                Console.WriteLine("Van welke rij wil je de som zien?");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SomNdeRij(numbers, row));

            }

            else if (Oefening == 2)
            {
                Meerdimensionaal.SomPerRij();

            }

            else if (Oefening == 3)
            {
                Meerdimensionaal.Pixels();
            }

            
        }

        public static double SomNdeRij(double[,] numbers, int row)
        {
            double berekening = 0;
            for (int i = 0; i < numbers.GetLength(row); i++)
            {
                berekening += numbers[row, i];
            }
            return berekening;
        }

        public static void SomPerRij()
        {
            Console.WriteLine("Hoeveel rijen telt je array?");
            int rowrange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoeveel kolommen telt je array?");
            int columnrange = Convert.ToInt32(Console.ReadLine());


            double[,] numbers = new double[rowrange , columnrange];

            for (int rownumber = 0; rownumber < rowrange; rownumber++)
            {
                for (int columnnumber = 0; columnnumber < columnrange; columnrange++)
                {


                    Console.WriteLine($"Waarde voor rij {rownumber + 1}, kolom {columnnumber + 1}?");
                    numbers[rownumber, columnnumber] = Convert.ToDouble(Console.ReadLine());


                }

            }
            Console.WriteLine("De sommen per rij zijn:");
            for (int rownumber = 0; rownumber < rowrange; rownumber++)
            {
                Console.WriteLine(SomNdeRij(numbers,rownumber));

            }
        }

        public static void Pixels()
        {
            Console.WriteLine("Hoeveel rijen wil je?");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel kolommen wil je?");
            int numberOfColumns = Convert.ToInt32(Console.ReadLine());
            ConsoleColor[,] image = new ConsoleColor[numberOfRows, numberOfColumns];

            while (true)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1 - Pixel kleuren");
                Console.WriteLine("2 - Afbeelding tonen");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Wat is de rij-index? (begin vanaf 0.)");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wat is de kolom-index? (begin vanaf 0.)");
                    int column = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Welke kleur wil je gebruiken?");
                    ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

                    for (int i = 0; i < colors.Length; i++)
                    {

                        Console.WriteLine($"{i}, {colors[i]} ");






                    }
                    int colorIndex = Convert.ToInt32(Console.ReadLine());
                    image[row, column] = colors[colorIndex];

                }
                else if (choice == 2)
                {
                    for (int row = 0; row < numberOfRows; row++)
                    {

                        for (int column = 0; column < numberOfColumns; column++)
                        {

                            Console.BackgroundColor = image[row, column];
                            Console.Write(" ");


                        }
                    }
                    Console.WriteLine();
                }
                }


            }


        }
    }



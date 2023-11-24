using System;
using static System.Net.Mime.MediaTypeNames;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Björns protein?: ");
            string protein = Console.ReadLine();
            double antalBokstäver = protein.Length;
            Console.Write("k?: ");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double svar = antalBokstäver / k;
            double svarRundad = Math.Round(svar);

            if (protein.Length % 2 == 0) // Jämt antal bokstäver
            {
                if (antalBokstäver == k)
                {
                    Console.WriteLine("Svar: 0");
                }
                else if (antalBokstäver > 2)// om protein är mer än 2 bokstäver
                {
                    //svar > 1 men jämn
                    //svar = 1
                    Console.WriteLine("Svar: " + (svarRundad-1));
                }
                else if (antalBokstäver == 2 && k > 1)
                {
                    {
                        // För många delningar
                        Console.WriteLine("Det går inte att klippa Björns protein med detta intervall.");
                        Console.WriteLine("Testa ge k värdet 1 om proteinet är två bokstäver lång.");
                    }
                }
            }


            else if (antalBokstäver % 3 == 0)
            {
                if (antalBokstäver == k)
                {
                    Console.WriteLine("Svar: 0");
                }
                else if (antalBokstäver > 1)// om protein är mer än 2 bokstäver
                {
                    //svar > 1 men jämn
                    //svar = 1
                    Console.WriteLine("Svar: " + (svarRundad-1));
                }
                else if ((antalBokstäver == 1 && k > 1)|| (antalBokstäver==3 && k!=2||k!=1))
                {
                    {
                        // För många delningar
                        Console.WriteLine("Det går inte att klippa Björns protein med detta intervall.");
                        Console.WriteLine("Testa ge k värdet 1 om proteinet är två bokstäver lång.");
                    }
                }
                else
                {
                    Console.WriteLine("Svar: 1");
                }
            }
            else
            {
                Console.WriteLine("Svar: 0");
            }
            Console.ReadKey();
        }
    }
}
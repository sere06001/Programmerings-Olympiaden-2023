using System;
namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal byggnader?: ");
            int antalByggnader = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Kostnad av Megapickeln?: ");
            double kostnadMegapickle = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Produktionshastighet och pris för byggnad 1?: ");
            string[] pris = Console.ReadLine().Split();
            int[] a = new int[antalByggnader * 2];
            for (int i = 0; i < pris.Length; i++)
            {
                a[i] = int.Parse(pris[i]);
            }
            double tid = Math.Round(kostnadMegapickle / a[0]);
            Console.WriteLine("Svar: " + tid);
            Console.ReadKey();
        }
    }
}
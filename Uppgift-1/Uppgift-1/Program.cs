using System;
namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ordet?: ");
            string ord = Console.ReadLine();
            Console.Write("Antal upprepningar?: ");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Svar: ");
            for (int i = 0; i < antal; i++)
            {
                Console.Write(ord);
            }
            Console.ReadKey();
        }
    }
}
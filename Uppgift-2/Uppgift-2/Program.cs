using System;
namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N?: ");
            long n = long.Parse(Console.ReadLine());
            int j = 0;
            for (long i = 0; i < n; i++)
            {
                long tal = i*(i+1)*(i+2);
                if (tal%3==0 && tal<n)
                {
                    j++;
                }
            }
            Console.WriteLine();
            Console.Write("Svar: "+(j-1));
            Console.ReadKey();
        }
    }
}
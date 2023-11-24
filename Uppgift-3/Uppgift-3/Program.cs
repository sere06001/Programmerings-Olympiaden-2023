using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N?: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M?: ");
            double m = int.Parse(Console.ReadLine());

            Console.Write("sn."); 
            for (int i = 0; i<m-3; i++) 
            { Console.Write(".");}
            Console.WriteLine();

            if (m > 3)
            {
                for (int i = 0; i < (m-3)/2; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(".");
                    }
                Console.WriteLine();
                }
            }
            

            for (int i = 0; i < (m-3) / 3; i++) 
            { Console.Write("."); } 
            Console.Write(".a.");
            if (m>5 && m%2==0) { Console.Write("."); }
            if (m == 4)
            {
                for (int i = 1; i < (m - 3) / 3; i++)
                    Console.Write(".");
            }
            else
            {
                for (int i = 0; i < (m - 3) / 3; i++)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            if (m > 3 && m!=4)
            {
                for (int i = 0; i < (m - 3) / 2; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < m - 3; i++) 
            { Console.Write("."); } 
            Console.WriteLine(".ke");
            Console.ReadKey();
        }
    }
}
using System;
using System.Data;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en uträkning");
            string input = Console.ReadLine();
            string summa = new DataTable().Compute(input, null).ToString();

            Console.WriteLine("Svaret är: " + summa);
            Console.ReadKey();
        }
    }
}

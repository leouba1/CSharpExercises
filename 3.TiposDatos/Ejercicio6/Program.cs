using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startFrom = -5;
            const int endAt = 5;

            Console.WriteLine("\nPrinting values for function: x = y2 + 2y + 1");

            for (var i=startFrom; i <= endAt ; i++)
            {
                Console.WriteLine($"y = {i} -> x = {i*i + 2*i + 1}");
            }
            
        }
    }
}
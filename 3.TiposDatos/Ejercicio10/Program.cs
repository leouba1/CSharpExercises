using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            var second = int.Parse(Console.ReadLine());

            if (first%2 == 0 && second%2 == 0)
                Console.WriteLine("Both are even");
            else if (first%2 != 0 && second%2 != 0)
                Console.WriteLine("Both are odd");
            else
                Console.WriteLine("One is even and the other is odd");
        }
    }
}

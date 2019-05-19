using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to convert: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary number: {0}",Convert.ToString(number,2));
        }
    }
}

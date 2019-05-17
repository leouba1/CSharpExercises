using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            var r = int.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter of the circle: {0:N2}", 2*Math.PI*r);
        }
    }
}

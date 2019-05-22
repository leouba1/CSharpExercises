using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise5
    {
        public static void Run()
        {
            Console.Write("Enter a radius: ");
            var r = int.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter of the circle: {0:N2}", 2*Math.PI*r);
        }
    }
}
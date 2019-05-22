using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise8
    {
        public static void Run()
        {
            Console.Write("Enter the radius of the sphere: ");
            var r = int.Parse(Console.ReadLine());

            Console.WriteLine("\nArea of the sphere: {0:N2}", 4*Math.PI*Math.Pow(r,2));
            Console.WriteLine("Volume of the sphere: {0:N2}", ((float)4/3)*Math.PI*Math.Pow(r,3));
        }
    }
}
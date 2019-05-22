using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise11
    {
        public static void Run()
        {
            Console.Write("Number to convert: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary number: {0}",Convert.ToString(number,2));
        }
    }
}
using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise10
    {
        public static void Run()
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
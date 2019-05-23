using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired width: ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("\n");
            for(var x=width;x>0;x--)
            {
                for(var i=0;i<x;i++)
                    Console.Write(num);
                Console.Write("\n");
            }
        }
    }
}
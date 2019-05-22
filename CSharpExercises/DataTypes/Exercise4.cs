using System;

namespace CSharpExercises.DataTypes
{
    public class Exercise4
    {
        public static void Run()
        {
            Console.WriteLine("Input first number: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input operation: ");
            var op = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            var num2 = int.Parse(Console.ReadLine());

            var result = 0;
            switch(op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operator not supported");
                    break;
            }

            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
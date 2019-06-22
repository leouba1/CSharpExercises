using System;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Your name has {0} characters",name.Length);
            Console.WriteLine("Enter another string: ");
            var otherString = Console.ReadLine();

            if (Strings.NameIncludedInString(name, otherString))
                Console.WriteLine("Your name is in the string");
            else
                Console.WriteLine("Your name is not in the string");
        }
    }
}

using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {   
            var input = string.Empty;
            do{
                Console.WriteLine("Insert a string to check palindrome: ");
                input = Console.ReadLine();
                if (Palindrome.Check(input))
                    Console.WriteLine($" {input} is palindrome \n");
                else
                    Console.WriteLine($" {input} is not a palindrome \n");
            }while(input != "exit");
            
        }
    }
}

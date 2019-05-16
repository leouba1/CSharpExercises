using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string userName = "username";
            const string password = "password";
            var success = false;

            for(var attempt = 0; attempt<3; attempt++)
            {
                Console.WriteLine("Please enter userID");
                var userInput = Console.ReadLine();
                Console.WriteLine("Please enter password");
                var passInput = Console.ReadLine();

                if(string.Equals(userInput,userName) && string.Equals(password,passInput))
                {
                    success = true;
                    break;
                }
                else
                    Console.WriteLine("Wrong username or password. Try again!");
            }

            if(success)
                Console.WriteLine($"Welcome {userName}");
            else
                Console.WriteLine("Too many wrong attemps!");
            
        }
    }
}

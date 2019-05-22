using System;
using System.Linq;
using System.Text;

namespace CSharpExercises.DataTypes
{
    public class Exercise9
    {
        public static void Run()
        {
            byte[] upperCaseVowels = Encoding.ASCII.GetBytes("AEIOU");
            byte[] lowerCaseVowels = Encoding.ASCII.GetBytes("aeiou");
            byte[] digits = Encoding.ASCII.GetBytes("0123456789");

            byte ascii_A = Encoding.ASCII.GetBytes("A").First();
            byte ascii_Z = Encoding.ASCII.GetBytes("Z").First();
            byte ascii_a = Encoding.ASCII.GetBytes("a").First();
            byte ascii_z = Encoding.ASCII.GetBytes("z").First();
            

            Console.WriteLine("Press any key: ");
            var key = Encoding.ASCII.GetBytes(Console.ReadLine()).First();

            if (upperCaseVowels.Contains(key))
                Console.WriteLine("It's an uppercase vowel!");

            else if (lowerCaseVowels.Contains(key))
                Console.WriteLine("It's a lowercase vowel");

            else if (digits.Contains(key))
                Console.WriteLine("It's a number");
            
            else if (key >= ascii_A && key <= ascii_Z)
                Console.WriteLine("It's an uppercase consonant");
            
            else if (key >= ascii_a && key <= ascii_z)
                Console.WriteLine("It's a lowercase consonant");

            else    
                Console.WriteLine("It's a symbol!");
            

            
        }
    }
}
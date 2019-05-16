using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeArray = new char[3];
            for(var x=0; x<3; x++)
            {
                Console.WriteLine("Please enter a leter");
                storeArray[x] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n{storeArray[2]} {storeArray[1]} {storeArray[0]} \n");
            
            // With for loop
            for(var i=storeArray.Length-1;i>=0;i--)
            {
                Console.Write(storeArray[i]+" ");
            }
            Console.WriteLine("\n");
            
        }
    }
}

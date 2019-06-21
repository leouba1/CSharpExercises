using System;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new int[][] 
            {
                new int[] {0, 1, 0, 1, 1},
                new int[] {0, 1, 1, 0, 1},
                new int[] {1, 0, 1, 0, 0},
                new int[] {1, 0, 0, 0},
                new int[] {1, 0, 0, 0, 0, 1}
            };

            foreach(var array in arrays)
            {
                foreach(var num in array) Console.Write(num + " ");
                Console.WriteLine($"\nPassing Cars: {PassingCars.Check(array)}\n");
            }            
        }
    }
}

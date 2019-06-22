using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
             var arrays = new int[][] 
            {
                new int[] {3, 8, 9, 7, 6},
                new int[] {0, 0, 0},
                new int[] {1, 2, 3, 4}
            };

            foreach(var array in arrays)
            {
                foreach(var num in CyclicRotation.Rotate(array,3))
                    Console.Write($"{num} ");
                Console.WriteLine();
            }     
        }
    }
}

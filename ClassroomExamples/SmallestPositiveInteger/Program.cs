using System;
using System.Collections.Generic;

namespace SmallestPositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new int[][] 
            {
                new int[] {1, 3, 6, 4, 1, 2},
                new int[] {3, 8, 9, 7, 6},
                new int[] {0, 0, 0},
                new int[] {1, 2, 3, 4},
                new int[] {-1, -3}
            };

            foreach(var array in arrays)
            {
                foreach(var num in array) Console.Write(num + " ");
                Console.WriteLine($"\nSmallest Positive Integer: {Solution.Run(array)}\n");
            }            

        }
    }
}

using System;

namespace OddOcurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new int[][] 
            {
                new int[] {9, 3, 9, 3, 9, 7, 9},
                new int[] {9, 3, 9, 3, 9, 5, 10, 10, 9},
                new int[] {2, 4, 4, 2, 3, 3, 9}
            };

            foreach(var test in arrays)            
                Console.WriteLine("The odd ocurrence of the array: {0}", OddOcurrencesInArray.GetUnpairedNumber_easy(test));
        }
    }
}

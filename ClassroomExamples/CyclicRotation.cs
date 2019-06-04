using System;

namespace ClassroomExamples
{
    public class CyclicRotation
    {
        public static void Test()
        {
            var arrays = new int[][] 
            {
                new int[] {3, 8, 9, 7, 6},
                new int[] {0, 0, 0},
                new int[] {1, 2, 3, 4}
            };

            foreach(var array in arrays)
            {
                foreach(var num in Rotate(array,3))
                    Console.Write($"{num} ");
                Console.WriteLine();
            }     
                
        }

        private static int[] Rotate(int[] array, int k)
        {
            var result = new int[array.Length];            

            for (var x = 0; x < k; x++)
            {
                for (var i = 0; i < array.Length - 1; i++)                    
                    result[i + 1] = array[i];
                
                result[0] = array[array.Length - 1];

                for(var j=0; j<array.Length;j++)                    
                    array[j] = result[j];                    
            }

            return result;
        }
    }
}
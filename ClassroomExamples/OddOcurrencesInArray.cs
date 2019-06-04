using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomExamples
{
    /// <summary>
    /// 
    // A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
    // For example, in array A such that:
    // A[0] = 9 A[1] = 3 A[2] = 9 A[3] = 3 A[4] = 9 A[5] = 7 A[6] = 9 the elements at indexes 0 and 2 have value 9, the elements at indexes 1 and 3 have value 3, the elements at indexes 4 and 6 have value 9, the element at index 5 has value 7 and is unpaired. Write a function:
    // class Solution { public int solution(int[] A); }
    // that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
    // For example, given array A such that:
    // A[0] = 9 A[1] = 3 A[2] = 9 A[3] = 3 A[4] = 9 A[5] = 7 A[6] = 9 the function should return 7, as explained in the example above.
    // Write an efficient algorithm for the following assumptions:
    // N is an odd integer within the range [1..1,000,000]; each element of array A is an integer within the range [1..1,000,000,000]; all but one of the values in A occur an even number of times.

    /// </summary>
    public class OddOcurrencesInArray
    {

        public static void Run()
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

        private static int GetUnpairedNumber(int[] A)
        {
            var list = A.ToList();
            var result = 0;
            
            foreach (var num in list)
            {                
                if(list.FindAll(n => n==num).Count() < 2)                
                    result = num;
            }

            return result;
        }

        private static int GetUnpairedNumber_easy(int[] A)
        {
            var result = 0;
            foreach(var num in A)
            {
                var count = 0;
                foreach(var pair in A)
                {
                    if(num == pair)
                        count++;
                }
                if(count == 1)
                    result = num;
            }
            return result;
        }

    }
}
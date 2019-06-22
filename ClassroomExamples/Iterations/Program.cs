using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {5, 8 ,9 , 140};
            foreach(var num in nums)            
                Console.WriteLine("Decimal: {0} - Binario: {1} - BinaryGap: {2} ", num, Convert.ToString(num,2), Iterations.BinaryGap(num));            
        }
    }
}

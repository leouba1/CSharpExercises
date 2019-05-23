using System;

namespace ClassroomExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 9;
            Console.WriteLine("Binario: {0} - BinaryGap: {1} ",Convert.ToString(num,2),Iterations.BinaryGap(num));
        }
    }
}

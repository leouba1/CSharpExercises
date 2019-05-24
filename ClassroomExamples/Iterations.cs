using System;

namespace ClassroomExamples
{
    public class Iterations
    {        
        public static int BinaryGap(int number)
        {
            bool start = true;
            int counter = 0, maxCounter = 0;
            string binary = Convert.ToString(number, 2);

            foreach (var digit in binary)
            {
                if (digit=='1' && start)                
                    start = false;
                
                else if (digit=='0')                
                    counter++;
                
                else if (digit=='1')
                {
                    if(maxCounter<counter)
                        maxCounter = counter;
                    
                    counter = 0;
                    start = true;
                }
            }
            return maxCounter;
        }
    }
}
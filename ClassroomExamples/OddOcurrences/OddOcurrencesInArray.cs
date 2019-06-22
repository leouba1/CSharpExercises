using System.Linq;

namespace OddOcurrences
{
    public class OddOcurrencesInArray
    {
        public static int GetUnpairedNumber(int[] A)
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

        public static int GetUnpairedNumber_easy(int[] A)
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
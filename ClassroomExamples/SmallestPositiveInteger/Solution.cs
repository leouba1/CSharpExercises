using System.Linq;

namespace SmallestPositiveInteger
{
    public class Solution
    {
        public static int Run(int[] A)
        {
            var aux = A.ToList();
            var min = 0;
            while(aux.Any())
            {
                min = aux.Min();
                if (aux.Contains(min+1) && min > 0)
                    aux.RemoveAll(x => x == min);

                else 
                    break;
            }
            
            return min+1;
        }

    }
}
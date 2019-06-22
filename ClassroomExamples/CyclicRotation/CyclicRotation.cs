namespace CyclicRotation
{
    public class CyclicRotation
    {
        public static int[] Rotate(int[] array, int k)
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
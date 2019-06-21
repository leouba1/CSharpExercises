using System.Collections.Generic;

namespace PassingCars
{
    public class PassingCars
    {
        public static int Check(int[] cars)
        {
            var eastPassingCars = new int();
            var result = new int();
            foreach (var car in cars)
            {
                if (car == 0)
                    eastPassingCars++;
                else if (car == 1)
                    result += eastPassingCars;
            }

            return result < 1000000000 ?  result : -1;
        }
    }
}
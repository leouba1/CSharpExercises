namespace House
{
    using System;
    public class House
    {
        public int Area {get; set;}
        public Door Door {get; set;}
        public House(int area)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a house and my area is {Area}");
        }

        public Door GetDoor()
        {
            return Door;
        }
    }
}
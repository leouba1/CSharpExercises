namespace House
{
    using System;
    public class Door
    {
        public string Color {get; set;}
        public Door(string color)
        {
            Color = color;
        }

        public void ShowData() 
        {
            Console.WriteLine($"I'm a door and my color is {Color}");
        }

    }
}
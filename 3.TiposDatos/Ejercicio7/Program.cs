using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance(meters): ");
            var meters = int.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(hour): ");
            var hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(minutes): ");
            var minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Input timeSec(seconds): ");
            var seconds = int.Parse(Console.ReadLine());

            var timeInSeconds = seconds + minutes*60 + hours*3600;

            Console.WriteLine("Your speed in meters/sec is " + meters/timeInSeconds);
            Console.WriteLine("Your speed in km/h is " + (meters/1000)/(timeInSeconds/3600));
            Console.WriteLine("Your speed in miles/h is " + (meters/1609.344)/(timeInSeconds/3600));
        }
    }
}

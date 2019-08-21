using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Loteria
    {
        public event Action<Loteria, int> GeneratingNumberEvent;

        public string Name { get; }
        public int WinningNumber { get; private set; }

        public Loteria(string name)
        {
            Name = name;
        }

        public void Run()
        {
            Random rnd = new Random();

            WinningNumber = rnd.Next() % 10;
            Console.WriteLine($"Soy {this.Name} y genere el numero: {WinningNumber}");
            GeneratingNumberEvent?.Invoke(this, WinningNumber);
        }
    }
}

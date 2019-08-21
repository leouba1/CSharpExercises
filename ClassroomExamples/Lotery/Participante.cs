using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Participante
    {
        public string Name { get; }
        public int Numero { get; set; }

        public Participante(string name, int num)
        {
            Name = name;
            Numero = num;
        }
        
        public void MyEventHandler(Loteria sender, int winningNumber)
        {
            var text = $"Soy {this.Name}, aposté al {this.Numero} Y {sender.Name} me informa que genero el numero {winningNumber} - ";
            text += Numero == winningNumber ? "GANE!" : "PERDI :(";
            Console.WriteLine(text);
        }
    }
}

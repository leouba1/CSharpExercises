using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Loteria: Es quien recibe las apuestas y realiza el sorteo. De acuerdo al resultado, tiene que informar a cada apostador si ganó o perdió.
                Apostador: Apuesta un número.
                Hacer un programa implemente este modelo, generando un numero random como el numero ganador.
            */

            var lot = new Loteria("Big Generator");
            var s1 = new Participante("Participante 1",new Random().Next() % 2);
            lot.GeneratingNumberEvent += s1.MyEventHandler;
            var s2 = new Participante("Participante 2", new Random().Next() % 2);
            lot.GeneratingNumberEvent += s2.MyEventHandler;

            lot.Run();
        }       
    }
}

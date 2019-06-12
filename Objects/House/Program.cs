using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Leandro");
            var smallAppartment = new SmallApartment();
            var door = new Door("Brown");

            smallAppartment.Door = door;
            person.House = smallAppartment;

            person.ShowHouse();
        }
    }
}

using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            var firstValue = Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            var secondValue = Console.ReadLine();

            Console.WriteLine("El resultado de la suma es: {0}", firstValue + secondValue);
        }
    }
}
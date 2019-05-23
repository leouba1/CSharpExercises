namespace ClassroomExamples
{
    
    using System;

    public class Strings
    {
        /// <summary>
        /// Escribir un programa que permita ingresar el nombre completo de una persona e Informe cuantos caracteres tiene este nombre.
        /// Luego solicite el ingreso de una cadena de caracteres e informe si el nombre incluye o no esta cadena de caracteres.
        /// Finalmente, que imprima el nombre al revés.
        /// </summary>
        public static void NameIncludedInString()
        {
            Console.Write("Insert your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Your name has {0} characters",name.Length);
            Console.WriteLine("Enter another string: ");
            var otherString = Console.ReadLine();
            
            if(otherString.Contains(name))            
                Console.WriteLine("Your name is in the string");
            
            else    
                Console.WriteLine("Your name is not in the string");

            for (var index=name.Length-1; index>=0; index--)
                Console.Write(name[index]);
        }
    }
}
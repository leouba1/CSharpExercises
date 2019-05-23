using System;

namespace CSharpExercises.DataTypes
{
    public class DataType
    {
        public void Run()
        {
            string answer = string.Empty;
            do
            {
                Console.WriteLine("##############################################################");
                Console.Write("Select exercise number (from 1 to 11) or type 'exit' to quit: ");                
                answer = Console.ReadLine();

                switch(answer)
                {
                    case "1":
                        Exercise1.Run();
                        break;
                    case "2":
                        Exercise2.Run();
                        break;
                    case "3":
                        Exercise3.Run();
                        break;
                    case "4":
                        Exercise4.Run();
                        break;
                    case "5":
                        Exercise5.Run();
                        break;
                    case "6":
                        Exercise6.Run();
                        break;
                    case "7":
                        Exercise7.Run();
                        break;
                    case "8":
                        Exercise8.Run();
                        break;
                    case "9":
                        Exercise9.Run();
                        break;
                    case "10":
                        Exercise10.Run();
                        break;
                    case "11":
                        Exercise11.Run();
                        break;
                    case "exit":
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Wrong answer!");
                        break;
                }
            }while(answer != "exit");
        }
    }
}
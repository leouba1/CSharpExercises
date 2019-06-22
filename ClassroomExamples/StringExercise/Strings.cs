namespace StringExercise
{    
    using System;

    public class Strings
    {        
        public static bool NameIncludedInString(string name, string otherString)
        {                 
            var result = new bool();       
            if(otherString.Contains(name))            
                result = true;
            
            else    
                result = false;

            for (var index=name.Length-1; index>=0; index--)
                Console.Write(name[index]);
            
            Console.WriteLine();
            return result;
        }
    }
}
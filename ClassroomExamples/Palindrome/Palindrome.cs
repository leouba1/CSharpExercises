namespace Palindrome
{
    public static class Palindrome
    {
        public static bool Check(string word)
        {
            var reverse = string.Empty;
            var aux = word.ToLowerInvariant();
            for(var idx = aux.Length-1; idx >= 0 ; idx--)
            {
                reverse += aux[idx];
            }
            
            return reverse.Equals(aux);
        }
    }
}
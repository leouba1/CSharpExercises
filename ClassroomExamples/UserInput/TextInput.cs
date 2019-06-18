using System.Collections.Generic;

namespace UserInput
{
    public class TextInput
    {
        protected string container = string.Empty;
        public virtual void Add(char c)
        {
            container += c;
        }

        public string GetValue()
        {
            return container;
        }

    }
}
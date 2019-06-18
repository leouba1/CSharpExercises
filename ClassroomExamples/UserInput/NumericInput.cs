namespace UserInput
{
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            var aux = new int();
            if (int.TryParse(c.ToString(),out aux))
            {
                container += c;
            }
        }
    }
}
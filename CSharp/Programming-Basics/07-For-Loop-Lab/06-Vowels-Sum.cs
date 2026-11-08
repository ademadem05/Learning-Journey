namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var alpha = new Dictionary<string, int>() 
            {
                ["a"] = 1,
                ["e"] = 2,
                ["i"] = 3,
                ["o"] = 4,
                ["u"] = 5,
            };
            string text = Console.ReadLine();

            int total = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string textAlpha = text[i].ToString();

            if (alpha.ContainsKey(textAlpha))
            {
                    total += alpha[textAlpha];
            }

            
            }
            Console.WriteLine(total);
        }
    }
}

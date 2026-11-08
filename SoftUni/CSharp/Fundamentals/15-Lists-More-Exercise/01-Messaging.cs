namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                string input = numbers[i];
                int value = 0;
                for (global::System.Int32 j = 0; j < input.Length; j++)
                {
                    value += ((int)input[j] - '0');
                }
                int index = value % text.Length;
                Console.Write(text[index]);
                text = text.Remove(index, 1);
            }


        }
    }
}

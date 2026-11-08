namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                for (global::System.Int32 j = 0; j <  n; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (global::System.Int32 k = 0; k < n; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}

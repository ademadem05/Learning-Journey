namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string reversetext = "";
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reversetext += value[i];
            }
            Console.WriteLine(reversetext);

        }
    }
}

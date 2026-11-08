namespace _9._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();
            if (character == character.ToLower())
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();

            int total = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                total += digit[i] - '0';
            }
            Console.WriteLine(total);
        }
    }
}

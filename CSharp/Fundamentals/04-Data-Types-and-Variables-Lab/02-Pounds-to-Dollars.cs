namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britisDollar = 1.31;
            float dollar = float.Parse(Console.ReadLine());
            Console.WriteLine($"{(britisDollar * dollar):F3}");
        }
    }
}

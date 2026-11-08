namespace _7._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            string type = Console.ReadLine();
            Console.WriteLine($"{name}{type}{family}");
        }
    }
}

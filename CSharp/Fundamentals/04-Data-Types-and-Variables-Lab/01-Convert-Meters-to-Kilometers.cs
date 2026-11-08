namespace _1._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());
            double kilometer = meter / 1000.0;

            Console.WriteLine(kilometer.ToString("F2"));   

        }
    }
}

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 0;
            for (int i = 1; i <= n; i++)
            {

                int water = int.Parse(Console.ReadLine());

                if (capacity + water > 255 || water > 255) { Console.WriteLine("Insufficient capacity!");  continue; }
        
                capacity += water;
            }
            Console.WriteLine(capacity);
        }
    }
}

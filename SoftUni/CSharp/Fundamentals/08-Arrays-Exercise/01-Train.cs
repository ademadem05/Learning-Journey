namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Wagons = new int[n];

            for (int i = 0; i < Wagons.Length; i++)
            {
                int numbs = int.Parse(Console.ReadLine());
                Wagons[i] = numbs;
            }
            foreach (int i in Wagons) 
            {
                Console.Write($"{i} ");
                
            }
            Console.WriteLine($"\n{Wagons.Sum()}");
        }
    }
}

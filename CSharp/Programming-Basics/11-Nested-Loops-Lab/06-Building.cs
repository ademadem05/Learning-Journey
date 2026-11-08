namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stage = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            //int evenORodd = 0;
            for (int i = stage; i >= 1; i--)
            {
                //evenORodd--;
                for (global::System.Int32 j = 0; j <= rooms-1; j++)
                {
                    if (i == stage)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

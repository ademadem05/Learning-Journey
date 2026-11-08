namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int validCombination = 0;
            for (int i = 0; i <= n; i++)
            {
                for (global::System.Int32 j = 0; j <= n; j++)
                {
                    for (global::System.Int32 k = 0; k <= n; k++)
                    {
                        if (i+j+k == n)
                        {
                            validCombination++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombination);
        }
    }
}

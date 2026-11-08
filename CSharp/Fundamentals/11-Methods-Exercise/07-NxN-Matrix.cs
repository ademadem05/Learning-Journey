namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxNMatrix(n);
        }
        static void NxNMatrix(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (global::System.Int32 j = 1; j <= n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

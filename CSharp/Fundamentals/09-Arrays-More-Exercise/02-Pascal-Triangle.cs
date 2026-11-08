namespace _2._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = new long[i+1];

                for (global::System.Int32 j = 0; j <= i; j++)
                {
                    if (j==0 || j==i)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
       
    }
}

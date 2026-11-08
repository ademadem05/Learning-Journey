namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int current = 1;
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (global::System.Int32 cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}

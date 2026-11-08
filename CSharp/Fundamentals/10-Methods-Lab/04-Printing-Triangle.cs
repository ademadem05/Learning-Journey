namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintingTriangles(1,num);
        }
        static void PrintingTriangles(int start, int end) 
        {
            for (int i = start; i <= end; i++)
            {
                for (global::System.Int32 j = 1; j < i+1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();

            }
            for (int i = end-1; i >= start; i--)
            {
                for (global::System.Int32 k = start ; k <= i ; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }

        }
    }
}

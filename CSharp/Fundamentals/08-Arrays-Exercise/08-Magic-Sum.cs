namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= array.Length -1; i++)
            {
                for (global::System.Int32 j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] + array[j] == magicNum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");                  
                    }
                    else
                    {
                        continue;
                    }
                }

            }

        }
    }
}

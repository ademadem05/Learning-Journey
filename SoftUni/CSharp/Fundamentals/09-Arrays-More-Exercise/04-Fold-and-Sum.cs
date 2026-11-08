namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] upperLength = new int[2 * k];
            int[] lowerLength = new int[2 * k];

            int upperIndex = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                upperLength[upperIndex] = arr[i];   
                upperIndex++;
            }

            for (int i = arr.Length - 1; i >= arr.Length - k; i--)
            {
                upperLength[upperIndex] = arr[i];
                upperIndex++;
            }

            for (int i = 0; i < 2 * k; i++)
            {
                lowerLength[i] = arr[i + k];
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int result = upperLength[i] + lowerLength[i];
                Console.Write(result + " ");
            }
            //Console.Write(string.Join(" ", upperLength));  
            //Console.WriteLine();
            //Console.Write(string.Join(" ", lowerLength));
        }
    }
}

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            int[] reversedNums = numbers.Reverse().ToArray();
            foreach (var item in reversedNums)
            {
               Console.Write($"{item} "); 
            }
            
        }
    }
}

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                numbers.Add(nums);
            }
            var desnumbers = numbers.OrderByDescending(x => x);
            foreach (var item in desnumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

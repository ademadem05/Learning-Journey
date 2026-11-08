namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>specialNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bomb = specialNumber[0];
            int detonation = specialNumber[1];

            while (numbers.Contains(bomb))
            {
                int bombindex = numbers.IndexOf(bomb);
                int start = Math.Max(0, bombindex - detonation);
                int end =  Math.Min(numbers.Count - 1, bombindex + detonation);
                int count = end - start + 1;
                numbers.RemoveRange(start, count);
            }
           
                //Console.Write(string.Join(" ", numbers));
            
            Console.WriteLine(numbers.Sum());
        }
    }
}

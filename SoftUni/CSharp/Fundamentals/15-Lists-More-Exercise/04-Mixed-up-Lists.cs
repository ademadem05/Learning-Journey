namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lowerBound = 0;
            int upperBound = 0;

            if (firstList.Count > secondList.Count)
            {
                lowerBound = Math.Min(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
                upperBound = Math.Max(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
            }
            else
            {
                lowerBound = Math.Min(secondList[0], secondList[1]);
                upperBound = Math.Max(secondList[0], secondList[1]);
            }

            List<int> mixedList = new List<int>();
            int iterations = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < iterations; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count - 1 - i]);
            }

            List<int> result = mixedList.Where(x => x > lowerBound && x < upperBound).OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

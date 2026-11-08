namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (counts.ContainsKey(wordInLowerCase))
                    counts[wordInLowerCase]++;
                else
                    counts.Add(wordInLowerCase, 1);
            }

            List<string> result = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                    result.Add(pair.Key);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

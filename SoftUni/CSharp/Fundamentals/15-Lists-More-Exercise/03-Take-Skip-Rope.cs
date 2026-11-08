namespace _03._TakeSkip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = new List<int>();
            string alphabet = "";

            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    int digit = int.Parse(item.ToString());
                    numbers.Add(digit);
                }
                else
                {
                    alphabet += item;
                }
            }

            List<int> TakeList = new List<int>();
            List<int> SkipList = new List<int>();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    TakeList.Add(numbers[i]);
                }
                else
                {
                    SkipList.Add(numbers[i]);
                }
            }
            string result = "";
            int currentIndex = 0;
            for (int i = 0; i < TakeList.Count; i++)
            {
                int takeCount = TakeList[i];
                int skipCount = 0;

                if (i < SkipList.Count)
                {
                    skipCount = SkipList[i];
                }
                if (currentIndex >= alphabet.Length)
                {
                    break;
                }
                int actualTake = Math.Min(takeCount, alphabet.Length - currentIndex);
                result += alphabet.Substring(currentIndex, actualTake);

                currentIndex += takeCount + skipCount;
            }
            Console.WriteLine(result);
        }
    }
}

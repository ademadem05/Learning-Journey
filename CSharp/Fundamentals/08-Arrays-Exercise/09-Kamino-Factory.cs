namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[length];
            int bestLength = -1;
            int bestStartIndex = length; 
            int bestSum = -1;
            int bestSampleIndex = 0;
            int currentSampleCounter = 0; 
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentDNA = input
                                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                
                int currentMaxSequence = 0;
                int currentStartIndex = 0;
                int tempCounter = 0;
                int currentSum = currentDNA.Sum();

                for (global::System.Int32 i = 0; i < currentDNA.Length; i++)
                {

                    if (currentDNA[i] == 1)
                    {
                        tempCounter++;

                        if (tempCounter > currentMaxSequence)
                        {
                            currentMaxSequence = tempCounter;
                            currentStartIndex = i - tempCounter + 1;
                        }
                    }
                    else
                    {
                        tempCounter = 0;
                    }
                }

                currentSampleCounter++;

                bool isBetter = false;
                if (currentMaxSequence > bestLength)
                {
                    isBetter = true;
                }
                else if (currentMaxSequence == bestLength)
                {
                    if (currentStartIndex < bestStartIndex)
                    {
                        isBetter = true;
                    }
                    else if (currentStartIndex == bestStartIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isBetter = true;
                        }
                    }
                }

                if (isBetter) 
                {
                    bestDNA = currentDNA;   
                    bestLength = currentMaxSequence;
                    bestStartIndex = currentStartIndex;
                    bestSum = currentSum;
                    bestSampleIndex = currentSampleCounter;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ', bestDNA)}");
        }
    }
}

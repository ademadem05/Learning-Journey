namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int finishLine = Arr.Count / 2;

            double leftTime = 0;
            for (int i = 0; i < finishLine; i++)
            {
                if (Arr[i] == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += Arr[i]; 
                }
            }
            double rightTime = 0;
            for (int i = Arr.Count - 1; i > finishLine; i--)
            {
                if (Arr[i] == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += Arr[i];
                }
            }
            if (rightTime > leftTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime:0.#}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime:0.#}");
            }
        }
    }
}

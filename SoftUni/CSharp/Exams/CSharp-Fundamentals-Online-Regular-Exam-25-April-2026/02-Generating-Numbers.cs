namespace denemelik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequanceOfNums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "add")
                {
                    // İlk 3 kelimeyi (add, to, start) atlayıp sayıları listeye çeviriyoruz
                    List<int> itemsToAdd = tokens.Skip(3).Select(int.Parse).ToList();
                    
                    // Listenin en başına (0. index) bu listeyi ekliyoruz
                    sequanceOfNums.InsertRange(0, itemsToAdd);
                }
                else if (command == "remove" && tokens[1] == "greater")
                {
                    int value = int.Parse(tokens[3]);
                    sequanceOfNums.RemoveAll(n => n > value);
                }
                else if (command == "replace")
                {
                    int value = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);
                    int index = sequanceOfNums.IndexOf(value);
                    if (index != -1)
                    {
                        sequanceOfNums[index] = replacement;
                    }
                }
                else if (command == "remove" && tokens[1] == "at")
                {
                    int index = int.Parse(tokens[3]);
                    if (index >= 0 && index < sequanceOfNums.Count)
                    {
                        sequanceOfNums.RemoveAt(index);
                    }
                }
                else if (command == "find")
                {
                    if (tokens[1] == "even")
                    {
                        Console.WriteLine(string.Join(" ", sequanceOfNums.Where(n => n % 2 == 0)));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", sequanceOfNums.Where(n => n % 2 != 0)));
                    }
                }
            }

            Console.WriteLine(string.Join(", ", sequanceOfNums));
        }
    }
}
namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string>PartyList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string name = tokens[0];

                if (tokens.Length == 4)
                {
                    if (PartyList.Contains(name))
                    {
                        PartyList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                }
                else if (tokens.Length == 3)
                {
                    if (PartyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        PartyList.Add(name);    
                        continue;
                    }
                }

            }
            foreach (var item in PartyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>collectOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Add")
                {
                    collectOfIntegers.Add(int.Parse(tokens[1]));
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= collectOfIntegers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    collectOfIntegers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index >= collectOfIntegers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    collectOfIntegers.Insert(index, number);
                }
                else if (command == "Shift")
                {
                    if (tokens[1] == "left")
                    {
                        int times = int.Parse(tokens[2]);
                        for (global::System.Int32 i = 0; i < times; i++)
                        {
                            
                            int num = collectOfIntegers[0];
                            collectOfIntegers.RemoveAt(0);
                            collectOfIntegers.Add(num);
                           
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        int times = int.Parse(tokens[2]);
                        for (global::System.Int32 i = 0; i < times; i++)
                        {
                            
                            int lastdigit = collectOfIntegers[collectOfIntegers.Count - 1];
                            collectOfIntegers.RemoveAt(collectOfIntegers.Count - 1);
                            collectOfIntegers.Insert(0, lastdigit);
                            
                        }
                    }
                }
            }
            Console.Write(string.Join(" ",collectOfIntegers));
        }
    }
}

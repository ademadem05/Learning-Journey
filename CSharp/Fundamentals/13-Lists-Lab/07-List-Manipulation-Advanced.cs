using System.Windows.Input;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isChanged = false; 
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                string command = input[0];

                if (command == "Add")
                {
                    int num = int.Parse(input[1]);
                    List.Add(num);
                    isChanged = true;

                }
                else if (command == "Remove")
                {
                    int num = int.Parse(input[1]);
                    List.Remove(num);
                    isChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int num = int.Parse(input[1]);
                    List.RemoveAt(num);
                    isChanged = true;

                }
                else if (command == "Insert")
                {
                    int num = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    List.Insert(index, num);
                    isChanged = true;
                }
                else if (command == "Contains")
                {
                    int num = int.Parse(input[1]);
                    if (List.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (command == "PrintEven")
                {
                    List.Where(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", List.Where(x => x % 2 == 0)));
                }

                else if (command == "PrintOdd")
                {
                    List.Where(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", List.Where(x => x % 2 != 0)));
                }

                else if (command == "GetSum")
                {
                    Console.WriteLine(List.Sum());
                }

                else if (command == "Filter")
                {
                    string condition = input[1];
                    int num = int.Parse(input[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", List.Where(x => x < num)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", List.Where(x => x > num)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", List.Where(x => x >= num)));

                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", List.Where(x => x <= num)));
                    }

                }


            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", List));
            }

        }
    }
}

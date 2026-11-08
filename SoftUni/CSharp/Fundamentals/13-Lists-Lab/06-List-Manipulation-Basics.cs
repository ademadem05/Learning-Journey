namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                string commnad = input[0];
                
                

                if (commnad == "Add")
                {
                    int num = int.Parse(input[1]);
                    List.Add(num);
                    
                }
                else if (commnad == "Remove")
                {
                    int num = int.Parse(input[1]);
                    List.Remove(num);
                }
                else if (commnad == "RemoveAt")
                {
                    int num = int.Parse(input[1]);
                    List.RemoveAt(num);

                }
                else if (commnad == "Insert")
                {
                    int num = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    List.Insert(index, num);
                }
            }
            Console.Write(string.Join(" ", List));
        }
    }
}

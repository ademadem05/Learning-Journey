namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Delete")
                {
                    int value = int.Parse(tokens[1]);
                    arr.RemoveAll(x => x == value);
                    
                }
                if (tokens[0] == "Insert")
                {
                    int value = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    arr.Insert(index, value);
                }
            }
            Console.Write(string.Join(" ",arr));
        }
    }
}

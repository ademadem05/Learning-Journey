namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().
                Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {

                string[] tokens = input.Split();
                if (tokens.Length == 2)
                {
                     //Console.WriteLine(input);
                    if (tokens[0] == "Add")
                    {
                        int value = int.Parse(tokens[1]);
                        wagons.Add(value);
                    } 
                }
                else
                {
                    int value = int.Parse(tokens[0]);
                    for (global::System.Int32 i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + value <=  maxCapacity )
                        {
                            wagons[i] += value;
                            break;
                        }
                    }
                }


            }
            Console.Write(string.Join(" ", wagons));
        }
    }
}

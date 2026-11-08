namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string>elemnts = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                elemnts.Add(Console.ReadLine());                
            }
            elemnts.Sort();

            for (int i = 0; i <= elemnts.Count - 1; i++)
            {
                Console.WriteLine($"{i+1}.{elemnts[i]}");
            }
        }
    }
}

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            

            List<int> list2 = list.Where(x => x > -1).ToList();
            if (list2.Any())
            {
                list2.Reverse();    
                Console.Write(string.Join(" ", list2)); 
            }
            else
            {
                Console.WriteLine("empty");
            }



        }
    }
}

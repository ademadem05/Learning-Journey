
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int longestList = 0;
            if (list1.Count > list2.Count) 
            {
                longestList = list1.Count;
            }
            else
            {
                longestList = list2.Count;
            }

            List<int> result = new List<int>();
            for (int i = 0; i <= longestList - 1; i++)
            {
                if (list1.Count > i)
                {
                    result.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    result.Add(list2[i]);
                }
            }
            Console.Write(string.Join(" ",result));
        }
    }
}

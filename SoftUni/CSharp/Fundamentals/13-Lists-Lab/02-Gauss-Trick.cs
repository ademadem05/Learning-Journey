namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.Write(string.Join(" ", list));
        }
    }
}

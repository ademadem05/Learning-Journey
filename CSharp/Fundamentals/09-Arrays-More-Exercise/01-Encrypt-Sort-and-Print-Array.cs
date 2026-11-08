namespace Arrays___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingArr(n);
        }
        static void PrintingArr(int n) 
        {
            List<int>List = new List<int>();  
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int lengthOfName = name.Length;
                string vowels = "aeiouAEIOU";
                  
                int num = 0;
                foreach (var item in name)
                {
                    if (vowels.Contains(item))
                    {
                        num += item * lengthOfName;
                    }
                    else
                    {
                        num += item / lengthOfName;
                    }
                }
                List.Add(num);
                
            }
            List.Sort();
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}

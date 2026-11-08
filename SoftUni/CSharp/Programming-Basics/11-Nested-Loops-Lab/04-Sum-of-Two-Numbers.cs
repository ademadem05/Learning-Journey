namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int equal = int.Parse(Console.ReadLine());

            int counter = 0;
            int finalI = 0;
            int finalJ = 0;
            bool flag = false;
            for (int i = n; i <= k; i++)
            {
                //iCounter++;
                for (global::System.Int32 j = n; j <= k; j++)
                {
                    //jCounter++;
                    counter++;
                    if (i + j == equal)
                    {
                        finalI = i;
                        finalJ = j;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Combination N:{counter} ({finalI} + {finalJ} = {equal})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {equal}");
            }
        }
    }
}

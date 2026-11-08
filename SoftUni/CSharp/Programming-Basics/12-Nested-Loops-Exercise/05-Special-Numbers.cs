namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                string iNum = i.ToString();
                for (global::System.Int32 j = 0; j < iNum.Length; j++)
                {
                    int digit = iNum[j] - '0';
                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                   
                }
            }

        }
    }
}

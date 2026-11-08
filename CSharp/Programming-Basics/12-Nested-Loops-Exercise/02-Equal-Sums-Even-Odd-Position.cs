namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNums = int.Parse(Console.ReadLine());
            int secondNums = int.Parse(Console.ReadLine());

            if (secondNums > firstNums)
            {
                
            }

            string strFirstNums = firstNums.ToString();
            string strSecondNums = secondNums.ToString();
           
            for (int i = firstNums; i <= secondNums; i++)
            {
            int evenSum = 0;
            int oddSum = 0;

                string iNum = i.ToString();
                for (global::System.Int32 j = 0; j < iNum.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        evenSum += int.Parse(iNum[j].ToString());
                    }
                    else
                    {
                        oddSum += iNum[j] - '0';
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(iNum + " ");
                }
            
            }
        }
    }
}

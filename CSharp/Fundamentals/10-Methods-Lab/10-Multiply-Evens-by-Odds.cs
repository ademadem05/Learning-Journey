namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine(); 
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        static int GetMultipleOfEvenAndOdds(string number)
        {
            int evenSum = 0;
            int oddSum = 0;

            
            string absoluteNumber = Math.Abs(int.Parse(number)).ToString();

            for (int i = 0; i < absoluteNumber.Length; i++)
            {
              
                int currentDigit = absoluteNumber[i] - '0';

                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
                else
                {
                    oddSum += currentDigit;
                }
            }

            return evenSum * oddSum;
        }
    }
}

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopInterger(n);
        }
        static void TopInterger(int n) 
        {
            
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool hasOddDigit = false;
                int currentNum = i;

                while (currentNum > 0)
                {

                    int digit = currentNum % 10;
                    sum += digit;

                    if (digit % 2 != 0)
                    {
                        hasOddDigit = true;
                    }
                    currentNum /= 10;
                }

                if (sum % 8 == 0 && hasOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}

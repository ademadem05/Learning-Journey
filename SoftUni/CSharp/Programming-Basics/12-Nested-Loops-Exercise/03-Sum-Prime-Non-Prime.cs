namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNum = 0;
            int NonprimeNum = 0;
            bool negative = false;
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") { break; }

                int nums = int.Parse(input);

                bool flag = false;

                if (nums < 0) { Console.WriteLine("Number is negative."); continue; }

                
                for (global::System.Int32 i = 2; i <= Math.Sqrt(nums); i++)
                {
                    if (nums % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    primeNum += nums;
                }
                else 
                {
                    NonprimeNum += nums;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {NonprimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {primeNum}");

        }
    }
}

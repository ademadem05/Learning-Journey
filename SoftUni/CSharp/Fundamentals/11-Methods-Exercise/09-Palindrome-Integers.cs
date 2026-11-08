namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromeInt();
        }
        static void PalindromeInt() 
        {
            while (true)
            {
                string nums = Console.ReadLine();

                if (nums == "END")
                {
                    break;
                }

                if (nums[0] == nums[nums.Length - 1])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}

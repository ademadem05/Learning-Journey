namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            SignOfInterger(num);
        }
        static void SignOfInterger(int num) 
        {
            if (0 > num)
            {
                Console.WriteLine($"The number {num} is negative. ");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero. ");
            }
            else
            {
                Console.WriteLine($"The number {num} is positive. ");
            }
        }
    }
}

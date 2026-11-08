namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = FirstTwoNumSum(num1, num2);
            Console.WriteLine(ThirdSubstract(sum, num3));
        }
        static int FirstTwoNumSum(int num1, int num2) 
        {
            return num1 + num2;
        }
        static int ThirdSubstract(int FirstMethod,int num3) 
        {
            return FirstMethod - num3;
        }
    }
}

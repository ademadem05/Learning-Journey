using System.Numerics;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int n =  int.Parse(Console.ReadLine());
            BigInteger greatesValue = -1;
            int snowballTIme = 0;
            int snowballshow = 0;
            int snowballquality = 0;
            for (int i = 1; i <= n; i++)
            {
                int snowBallShow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowBallShow / snowBallTime), snowBallQuality);
                if (snowBallValue > greatesValue) 
                {
                    greatesValue = snowBallValue;
                    snowballTIme = snowBallTime;
                    snowballshow = snowBallShow;
                    snowballquality = snowBallQuality;
                }
             
            }
            Console.WriteLine($"{snowballshow} : {snowballTIme} = {greatesValue} ({snowballquality}) ");
        }
    }
}

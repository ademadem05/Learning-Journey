namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum = int.Parse(Console.ReadLine());

            if (100 <= userNum && userNum <= 200 || userNum == 0)
            {
                
            }
            else 
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

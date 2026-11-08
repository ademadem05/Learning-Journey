namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int MaxNum = int.MinValue;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Stop")
                {
                    break;
                }

                int Num = int.Parse(input);

                if (Num > MaxNum)
                {
                    MaxNum = Num;
                }
            }
            Console.WriteLine(MaxNum);
        }
    }
}

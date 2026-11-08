namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int MinNum = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Stop")
                {
                    break;
                }

                int Num = int.Parse(input);

                if (Num < MinNum)
                {
                    MinNum = Num;
                }
            }
            Console.WriteLine(MinNum);
        }
    }
}

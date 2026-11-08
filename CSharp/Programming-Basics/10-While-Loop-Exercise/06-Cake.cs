namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine()); 
            int width = int.Parse(Console.ReadLine());

            int wholecake = lenght * width;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int cakeTaken = int.Parse(input);
                wholecake -= cakeTaken;

                if (wholecake < 0) 
                {
                    break;
                }
            }

            if (wholecake < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(wholecake)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{wholecake} pieces are left.");
            }
        }
    }
}

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine()); 

            double cubicMeter = lenght * width * height;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                int cubic = int.Parse(input);
                cubicMeter -= cubic;

                if (cubicMeter < 0)
                {
                    break;
                }
            }
            if (cubicMeter < 0) 
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeter)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{cubicMeter} Cubic meters left.");
            }
        }
    }
}

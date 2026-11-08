namespace _09.FishTank
{
    internal class Program
    {
        static void Main()
        {
            //От конзолата се четат 4 реда:
            //1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000]

            //105
            //77
            //89
            //18.5

            //85
            //75
            //47
            //17


            string?Length = Console.ReadLine();
            string? Width = Console.ReadLine();
            string? Height = Console.ReadLine();
            string? Percent = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Length) && 
                String.IsNullOrWhiteSpace(Width) && 
                String.IsNullOrWhiteSpace(Height) && 
                String.IsNullOrWhiteSpace(Percent))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                int length = int.Parse(Length);
                int width = int.Parse(Width);
                int height = int.Parse(Height);
                double percent = double.Parse(Percent);

                double total = length * width * height;
                double toLiter = total / 1000;
                double neededWater = toLiter * (1 - (percent / 100));
                Console.WriteLine(neededWater);

            }

        }
    }
}

namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hour = int.Parse(Console.ReadLine()); 
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek) {
                case "Monday": 
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else 
                    {
                        Console.WriteLine("closed");
                    }
                    break;


                case "Tuesday":
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Wednesday":
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Thursday":
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Friday":
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Saturday":
                    if (10 <= Hour && Hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Sunday":
                    Console.WriteLine("closed");
                    break;
            }
        }
    }
}

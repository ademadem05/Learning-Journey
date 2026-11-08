namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int travelDays = int.Parse(Console.ReadLine());
            string Room = Console.ReadLine();   
            string rate = Console.ReadLine();


            var Price = new Dictionary<string, double>()
            {
                ["room for one person"] = 18.00,
                ["apartment"] = 25.00,
                ["president apartment"] = 35.00
            };

            double total = Price[Room] * (travelDays - 1);


            if (Room == "room for one person")
            {
                if (travelDays <10)
                {
                    
                }
                else if (10 <= travelDays && travelDays <= 15)
                {
                    
                }
                else if (travelDays > 15)
                {
                    
                }
            }
            else if (Room == "apartment")
            {
                if (travelDays < 10)
                {
                    total *= 0.70;
                }
                else if (10 <= travelDays && travelDays <= 15)
                {
                    total *= 0.65;
                }
                else if (travelDays > 15)
                {
                    total *= 0.50;
                }

            }
            else if (Room == "president apartment")
            {
                if (travelDays < 10)
                {
                    total *= 0.90;
                }
                else if (10 <= travelDays && travelDays <= 15)
                {
                    total *= 0.85;
                }
                else if (travelDays > 15)
                {
                    total *= 0.80;
                }
            }

            if (rate == "positive")
            {
                total *= 1.25;
            }
            else if (rate == "negative")
            {
                total *= 0.90;
            }

            Console.WriteLine(total.ToString("F2"));

        }
    }
}

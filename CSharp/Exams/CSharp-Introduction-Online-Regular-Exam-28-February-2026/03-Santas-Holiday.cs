namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var homeCatolog = new Dictionary<string, double >() 
            {
                ["room for one person"] = 18.00,
                ["apartment"] = 25.00,
                ["president apartment"] = 35.00
            }; 

            int dayTaken = int.Parse(Console.ReadLine());
            string typeroom = Console.ReadLine();   
            string grade = Console.ReadLine();

            double total = 0;

            total += homeCatolog[typeroom] * (dayTaken - 1);

            if (dayTaken < 10)
            {
                if (typeroom == "apartment")
                {
                    total *= 0.70;
                }
                else if (typeroom == "president apartment")
                {
                    total *= 0.90;
                }
            }
            else if (10 <= dayTaken && dayTaken <= 15)
            {
                if (typeroom == "apartment")
                {
                    total *= 0.65;
                }
                else if (typeroom == "president apartment")
                {
                    total *= 0.85;
                }
            }
            else
            {
                if (typeroom == "apartment")
                {
                    total *= 0.50;
                }
                else if (typeroom == "president apartment")
                {
                    total *= 0.80;
                }
            }

            if (grade == "positive")
            {
                total *= 1.25;
            }
            else if (grade == "negative")
            {
                total *= 0.90;
            }

           Console.WriteLine($"{total:F2}");
        }

    }
}

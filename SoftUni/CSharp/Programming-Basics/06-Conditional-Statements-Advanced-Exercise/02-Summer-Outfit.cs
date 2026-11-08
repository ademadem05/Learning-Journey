namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Degree = int.Parse(Console.ReadLine());
            string DayTime = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";

            switch (DayTime) 
            {
                case "Morning":
                    if (10 <= Degree && Degree <=18)
                    {
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                    }
                    else if(18 < Degree && Degree <= 24) 
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else if (Degree >= 25)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                    }
                    break;

                case "Afternoon":
                    if (10 <= Degree && Degree <= 18)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                    }
                    else if (18 < Degree && Degree <= 24)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                    }
                    else if (Degree >= 25)
                    {
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                    }
                    break;

                case "Evening":
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    break;
            };

            Console.WriteLine($"It's {Degree} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}

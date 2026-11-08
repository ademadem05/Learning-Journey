namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main()
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double veganMenu = 8.15;

            string? ChickenOrder = Console.ReadLine();
            string? FishOrder = Console.ReadLine();
            string? VeganOrder = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ChickenOrder) &&
                string.IsNullOrWhiteSpace(FishOrder) &&
                string.IsNullOrWhiteSpace(VeganOrder)
                )

                Console.WriteLine("Invalid Input");
            else
            {
                int Chicken = int.Parse(ChickenOrder);
                int Fish = int.Parse(FishOrder);
                int vegan = int.Parse(VeganOrder);

                double totalPrice = (chickenMenu * Chicken) + (fishMenu * Fish) + (veganMenu * vegan);
                double desertPrice = totalPrice * 0.2;
                double delivery = 2.50;
                double finalPrice = totalPrice + desertPrice + delivery;
                Console.WriteLine(finalPrice);


            }
        }
    }
}

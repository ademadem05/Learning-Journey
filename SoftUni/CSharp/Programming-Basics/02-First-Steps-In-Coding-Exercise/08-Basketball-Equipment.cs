namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main()
        {
            string? BasketballAnnual = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(BasketballAnnual)){
                Console.WriteLine("Invalid");
            }
            else
            {
                int basketAnnualBill = int.Parse(BasketballAnnual);

                double priceSneakers = basketAnnualBill - (basketAnnualBill * 0.4);
                double priceEquip = priceSneakers- (priceSneakers * 0.2);
                double priceBall = priceEquip / 4;
                double priceAccesoaries = priceBall / 5;

                double price = priceSneakers + priceEquip + priceBall + priceAccesoaries + basketAnnualBill;
                Console.WriteLine(price);


            }
        }
    }
}

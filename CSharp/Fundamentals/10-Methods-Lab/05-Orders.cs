namespace _05._Orders
{
    internal class Program
    {
        static void Main()
        {
           string nameOfProduct = Console.ReadLine();
           int quantityOfproduct = int.Parse(Console.ReadLine());
           Console.WriteLine(Order(nameOfProduct,quantityOfproduct).ToString("F2"));



        }
        static double Order(string product, int  quantity) 
        {

             var Products = new Dictionary<string, double> 
            {
                ["coffee"] = 1.50,
                ["water"] = 1.00,
                ["coke"] = 1.40,
                ["snacks"] = 2.00
            };

            double price = Products[product] * quantity;
            return price;

        }
    }
}

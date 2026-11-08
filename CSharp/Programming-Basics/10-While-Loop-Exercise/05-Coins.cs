namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] moneyCatalog =
              {
                 200,
                 100,
                 50,
                 20,
                 10,
                 5,
                 2,
                 1
            };

            double money = double.Parse(Console.ReadLine());
            double moneyIncents = Math.Round(money * 100);
            //Console.WriteLine(moneyIncents);
            int coinCounter = 0;
            while (true)
            {
                if (moneyIncents >= moneyCatalog[0])
                {
                    moneyIncents -= moneyCatalog[0];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[1])
                {
                    moneyIncents -= moneyCatalog[1];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[2])
                {
                    moneyIncents -= moneyCatalog[2];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[3])
                {
                    moneyIncents -= moneyCatalog[3];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[4])
                {
                    moneyIncents -= moneyCatalog[4];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[5])
                {
                    moneyIncents -= moneyCatalog[5];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[6])
                {
                    moneyIncents -= moneyCatalog[6];
                    coinCounter++;
                }
                else if (moneyIncents >= moneyCatalog[7])
                {
                     moneyIncents -= moneyCatalog[7];
                    coinCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(coinCounter);
        }
    }
}

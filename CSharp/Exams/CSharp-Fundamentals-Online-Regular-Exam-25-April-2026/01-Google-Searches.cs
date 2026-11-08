namespace denemelik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerSearch = double.Parse(Console.ReadLine());   
            int numbersOfUsers = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            for (int i = 1; i <= numbersOfUsers; i++)
            {
                int searchOfUser = int.Parse(Console.ReadLine());

                if (searchOfUser <= 1)
                {
                    continue;
                }

                else if (i % 3 == 0)
                {
                        if (searchOfUser > 5)
                        {
                            totalMoney += (searchOfUser * moneyPerSearch) * 6;
                        }
                        else
                        {
                             totalMoney += (searchOfUser * moneyPerSearch) * 3;
                    }
                }

                else if (searchOfUser > 5)
                {
                    totalMoney += (searchOfUser * moneyPerSearch) * 2;
                }

                else if (searchOfUser <= 1)
                {
                    continue;
                }

                else
                {
                    totalMoney += (searchOfUser * moneyPerSearch);
                }

            }
            Console.WriteLine($"Total money earned: {totalMoney:0.00}");
        }
    }
}

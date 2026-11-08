namespace CSharpLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());  
            double currentMoney = double.Parse(Console.ReadLine());

            int dayCounter = 0;
            int spendCounter = 0;
            bool flag = false;
            while (true)
            {
                string action = Console.ReadLine();
                double moneySpendORsaved = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    currentMoney += moneySpendORsaved;
                    dayCounter++;
                    spendCounter = 0;
                    if (currentMoney >= neededMoney)
                    {
                        flag = true;
                        break;
                    }
                }
                else if (action == "spend")
                {
                    currentMoney -= moneySpendORsaved;
                    dayCounter++;
                    spendCounter++;

                    if (currentMoney < 0 )
                    {
                        currentMoney = 0;
                    }
                    if (spendCounter >= 5)
                    {
                        break;
                    }
                }
            }

            if (flag)
            {    
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(dayCounter);
            }

        }
    }
}

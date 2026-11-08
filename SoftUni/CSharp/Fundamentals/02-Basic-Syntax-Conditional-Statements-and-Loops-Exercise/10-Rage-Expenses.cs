namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());  
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double total = 0;
            int keyboardTrashCount = 0;
            for (int i = 1; i <=lostgames; i++)
            {
                if (i % 2 == 0)
                {
                    total += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    total += mousePrice;
                }
                if (i % 6 == 0)
                {
                    total += keyboard;
                    keyboardTrashCount++;
                    if (keyboardTrashCount % 2 == 0)
                    {
                        total += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            int mussala = 0;
            int monblan = 0;
            int klimandjero = 0;
            int k2 = 0;
            int everest = 0;

            double totalGroup = 0;
            for (int i = 1; i <= n; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                totalGroup += userInput;

                if (userInput <= 5) 
                {
                    mussala += userInput;
                }
                else if (6 <= userInput && userInput <= 12)
                {
                    monblan += userInput;
                }
                else if (13 <= userInput && userInput <=25)
                {
                    klimandjero += userInput;
                }
                else if (26 <= userInput && userInput <= 40)
                {
                    k2 += userInput;
                }
                else 
                {
                    everest += userInput;
                }
            }

            Console.WriteLine($"{(mussala / totalGroup) * 100:F2}%");
            Console.WriteLine($"{(monblan / totalGroup) * 100:F2}%");
            Console.WriteLine($"{(klimandjero / totalGroup) * 100:F2}%");
            Console.WriteLine($"{(k2 / totalGroup) * 100:F2}%");
            Console.WriteLine($"{(everest / totalGroup) * 100:F2}%");
        }
    }
}

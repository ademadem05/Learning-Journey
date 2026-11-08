namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //< 200 53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65 12 p1 = 12 / 20 * 100 = 60.00 %

            //    200 … 399 250, 200 2 p2 = 2 / 20 * 100 = 10.00 %

            //    400 … 599 450 1 p3 = 1 / 20 * 100 = 5.00 %

            //    600 … 799 680, 600, 799 3 p4 = 3 / 20 * 100 = 15.00 %

            //    ≥ 800 920, 800 2 p5 = 2 / 20 * 100 = 10.00


            int n = int.Parse(Console.ReadLine());


            double total = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;


            for (int i = 1; i <= n; i++) 
            {
                int userInput = int.Parse(Console.ReadLine());

               

                if (userInput < 200)
                {
                    p1++;
                    total++;
                }
                else if (200 <= userInput && userInput <= 399)
                {
                    p2++;
                    total++;
                }
                else if (400 <= userInput && userInput <=599)
                {
                    p3++;
                    total++;
                }
                else if (600 <= userInput && userInput <= 799)
                {
                    p4++;
                    total++;
                }
                else
                {
                    p5++;
                    total++;
                }

              
            }
                Console.WriteLine($"{(p1 / total * 100):F2}%");
                Console.WriteLine($"{(p2 / total * 100):F2}%");
                Console.WriteLine($"{(p3 / total * 100):F2}%");
                Console.WriteLine($"{(p4 / total * 100):F2}%");
                Console.WriteLine($"{(p5 / total * 100):F2}%");

        }
    }
}

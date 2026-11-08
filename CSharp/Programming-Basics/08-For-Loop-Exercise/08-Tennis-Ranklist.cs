namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTournaments = int.Parse(Console.ReadLine());
            int Points = int.Parse(Console.ReadLine());

            int w = 0;
            int f = 0;
            int sf = 0;

            double winning = 0;
            for (int i = 1; i <= countOfTournaments; i++)
            {
                string tournament = Console.ReadLine();
                if (tournament.ToLower() == "sf")
                {
                    sf += 720;
                }
                else if (tournament.ToLower() == "w")
                {
                    w += 2000;
                    winning++;
                }
                else if (tournament.ToLower() == "f")
                {
                    f += 1200;
                }
            }
            double totalPoint = Points + w + f + sf;
            double averagePoint =(w + f + sf) /countOfTournaments;

            double winGame = (winning / countOfTournaments) * 100;

            Console.WriteLine($"Final points: {totalPoint}");
            Console.WriteLine($"Average points: {averagePoint}");
            Console.WriteLine($"{winGame:F2}%");

        }
    }
}

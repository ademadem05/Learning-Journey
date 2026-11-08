using System.Collections.Generic;
using System.Linq;
namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (player1.Count > 0 && player2.Count > 0)
            {
                if (player1[0] > player2[0])
                {
                    int lostPoint = player2[0];
                    player2.RemoveAt(0);
                    int winnerPoint = player1[0];
                    player1.RemoveAt(0);
                    player1.Add(winnerPoint);
                    player1.Add(lostPoint); 
                }
                else if (player1[0] < player2[0])
                {
                    int lostPoint = player1[0];
                    player1.RemoveAt(0);
                    int winnerPoint = player2[0];
                    player2.RemoveAt(0);
                    player2.Add(winnerPoint);
                    player2.Add(lostPoint);
                }
                else
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
            }
            string winner = player1.Count >= player2.Count ? "First" : "Second";
            int total = player1.Count >= player2.Count ? player1.Sum() : player2.Sum();
            Console.WriteLine($"{winner} player wins! Sum: {total}");
        }
    }
}

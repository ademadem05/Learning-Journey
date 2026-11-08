namespace _08._Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var tickets = new Dictionary<string, int>()
            {
                ["Monday"] = 12,
                ["Tuesday"] = 12,
                ["Wednesday"] = 14,
                ["Thursday"] = 14,
                ["Friday"] = 12,
                ["Saturday"] = 16,
                ["Sunday"] = 16
            };

            string DayOfweek = Console.ReadLine();
            Console.WriteLine(tickets[DayOfweek]);

        }
    }
}

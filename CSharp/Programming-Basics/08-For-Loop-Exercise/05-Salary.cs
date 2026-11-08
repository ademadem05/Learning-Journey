namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fine = new Dictionary<string, int>()
            {
                ["Facebook"] = 150,
                ["Instagram"] = 100,
                ["Reddit"] = 50
            };

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string sites = Console.ReadLine();


                if (fine.ContainsKey(sites))
                {
                    salary -= fine[sites];

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);

            }
        }
    }
}

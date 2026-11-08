namespace _01.Excellent_Result
{
    internal class Program
    {
        static void Main()
        {
            string? STgrade = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(STgrade))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                double grade = double.Parse(STgrade);

                if (grade >=  5.50)
                {
                    Console.WriteLine("Excellent!");
                }
                else
                {
                    
                }
            }
        }
    }
}

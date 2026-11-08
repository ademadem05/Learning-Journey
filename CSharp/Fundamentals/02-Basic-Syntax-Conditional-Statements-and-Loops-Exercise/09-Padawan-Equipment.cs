namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());    
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfrobes = double.Parse(Console.ReadLine());
            double priceOfbelts = double.Parse(Console.ReadLine());

            int freebelts = countOfStudents / 6 ;

            double sabersCount = Math.Ceiling(countOfStudents * 1.10);
            double total  = priceOfLightsaber * sabersCount + priceOfrobes * (countOfStudents) + priceOfbelts * (countOfStudents - freebelts);

            if (total > money)
            {
                Console.WriteLine($"John will need {total - money:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
                
        }
    }
}

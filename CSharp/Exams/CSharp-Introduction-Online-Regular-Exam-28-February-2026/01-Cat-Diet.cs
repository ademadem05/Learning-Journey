namespace _01._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gramOFfat = 9;
            int gramOFprotein = 4;
            int gramOFcarbon = 4;

            int percentFat = int.Parse(Console.ReadLine());
            int percentProtein = int.Parse(Console.ReadLine());
            int percentCarbohydrat = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percentWaterIntake = int.Parse(Console.ReadLine());


            double totalGramsOfFat = ((percentFat / 100.0) * totalCalories) / gramOFfat;
            double totalGramOFProtein = ((percentProtein / 100.0) * totalCalories) / gramOFprotein;
            double totalGramOFCarbon = ((percentCarbohydrat / 100.0) * totalCalories) / gramOFcarbon;

            double weightOFFood = totalGramOFCarbon + totalGramsOfFat + totalGramOFProtein;

            double caloriesOFOneGramFood = totalCalories / weightOFFood;

            double finalCalories = caloriesOFOneGramFood * (1 - (percentWaterIntake / 100.0));

            Console.WriteLine($"{finalCalories:F4}");
        }
    }
}

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int appraisers = int.Parse(Console.ReadLine());

            double totalPoints = pointsOfAcademy;
            for (int i = 1; i <= appraisers; i++)
            {
                string nameOfAppraisers = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                totalPoints += (nameOfAppraisers.Length * points) / 2;

                if (totalPoints > 1250) 
                {
                    break;
                }
            }

            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {Math.Abs(totalPoints - 1250.5):F1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:F1}!");
            }
        }
    }
}

using System.Numerics;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juries = int.Parse(Console.ReadLine());

            int counter = 0;
            double totalPoints = 0;
            while (true)
            {
                string nameOfPresentation = Console.ReadLine();
                double pointsPerPresent = 0;

                if(nameOfPresentation == "Finish") { break; }

                for (global::System.Int32 i = 1; i <= juries; i++)
                {
                    double points = double.Parse(Console.ReadLine());
                    totalPoints += points;
                    pointsPerPresent += points;
                    counter++;
                }

                Console.WriteLine($"{nameOfPresentation} - {(pointsPerPresent / juries):F2}.");

            }
            
            Console.WriteLine($"Student's final assessment is {(totalPoints / counter):F2}.");
        }
    }
}

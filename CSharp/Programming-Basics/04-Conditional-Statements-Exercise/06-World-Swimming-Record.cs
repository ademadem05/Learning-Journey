namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main()
        {
            //От конзолата се четат 3 реда:
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]


            double RecordOfSeconds = double.Parse(Console.ReadLine());      
            double DistanceOfMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double NeededTOpass = DistanceOfMeters * secondsPerMeter;

            double WaterResistance = (Math.Floor(DistanceOfMeters / 15)) * 12.5;

            double TotalTime = NeededTOpass + WaterResistance;

            if (RecordOfSeconds > TotalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {(TotalTime):F2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {(TotalTime - RecordOfSeconds):F2} seconds slower.");
            }
        }
    }
}

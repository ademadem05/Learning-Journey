using System.Numerics;

namespace _1._1_Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            DateTime startTime = DateTime.Today.AddHours(hour).AddMinutes(minute);

            DateTime futureTime = startTime.AddMinutes(30);
            Console.WriteLine(futureTime.ToString("H:mm"));
        }
    }
}

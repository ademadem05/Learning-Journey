namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main()
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

            int totalHour = (inputHours * 60) + inputMinutes;
            int NewHourAndMinute = totalHour + 15;

            int Hours = NewHourAndMinute / 60;
            int Minutes = NewHourAndMinute % 60;


            if (Hours > 23) 
            {
                Hours = 0;
            }


            if (Minutes < 10) 
            {
                Console.WriteLine($"{Hours}:0{Minutes}");
            }
            else 
            {
                Console.WriteLine($"{Hours}:{Minutes}");
            }
            
        }
    }
}

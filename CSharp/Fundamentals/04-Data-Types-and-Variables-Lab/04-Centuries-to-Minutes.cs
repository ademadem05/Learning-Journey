namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centurie = int.Parse(Console.ReadLine());
            int years = centurie * 100;
            int days = (int)(years * 365.2422);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            Console.WriteLine($"{centurie} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }

    }
}

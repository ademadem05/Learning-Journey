namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dayofWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            try 
            {
                Console.WriteLine(dayofWeek[n - 1]);
            }
            catch 
            {
                Console.WriteLine("Invalid day!");
            }   
        }
    }
}

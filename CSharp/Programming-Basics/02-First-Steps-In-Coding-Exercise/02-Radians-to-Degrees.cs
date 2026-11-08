
namespace Exercise
{
    internal class _02
    {
        static void Main()
        {
            
            string? input  = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("The input is Null");
                return;
            }
            else
            {
                double radius = double.Parse(input);
                double degree = radius * 180 / Math.PI;
                Console.WriteLine(degree);
            }
        }
    }
}
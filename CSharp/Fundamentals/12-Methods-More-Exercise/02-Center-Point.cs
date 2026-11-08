
namespace _2._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterPoint(x,y,x2,y2);
        }
        static void CenterPoint(double x, double y, double x2, double y2) 
        {
            double res1 = Math.Pow(x, 2) + Math.Pow(y, 2);
            double res2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (res1 > res2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else 
            {
                Console.WriteLine($"({x}, {y})");
            }
        }
    }
}

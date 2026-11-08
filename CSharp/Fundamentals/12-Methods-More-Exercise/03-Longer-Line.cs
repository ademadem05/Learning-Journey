using System;

namespace _2._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (length1 >= length2)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }
        }

        static void PrintLine(double xA, double yA, double xB, double yB)
        {
            double distA = Math.Pow(xA, 2) + Math.Pow(yA, 2);
            double distB = Math.Pow(xB, 2) + Math.Pow(yB, 2);

            if (distA <= distB)
            {
                Console.WriteLine($"({xA}, {yA})({xB}, {yB})");
            }
            else
            {
                Console.WriteLine($"({xB}, {yB})({xA}, {yA})");
            }
        }
    }
}
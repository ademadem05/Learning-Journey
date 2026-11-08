namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main()
        {
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(Width, Height));
        }
        static double GetRectangleArea(double Width, double Height) 
        {
            return Width * Height;
        }
    }
}

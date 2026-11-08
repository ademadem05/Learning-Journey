namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double Base = double.Parse(Console.ReadLine());  
           int power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(Base, power));
        }
        static double MathPower(double Base, int power) 
        {
            return Math.Pow(Base, power);
        }
        
    }
}

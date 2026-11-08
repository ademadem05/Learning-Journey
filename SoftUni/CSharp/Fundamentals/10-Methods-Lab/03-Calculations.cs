namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
           Calculations(Console.ReadLine(),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
        }
        static void Calculations(string type, int num1, int num2) 
        {
            if (type == "add")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (type == "multiply")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (type == "subtract")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (type == "divide")
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}

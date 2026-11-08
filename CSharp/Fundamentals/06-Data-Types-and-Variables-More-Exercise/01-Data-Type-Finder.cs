
namespace _1._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string variable = Console.ReadLine();
                if(variable == "END") { break; }

                if (int.TryParse(variable, out var value1))
                {
                    Console.WriteLine($"{variable} is integer type");
                }
                else if (double.TryParse(variable, out var value2))
                {
                    Console.WriteLine($"{variable} is floating point type");
                }
                else if (bool.TryParse(variable, out var value4))
                {
                    Console.WriteLine($"{variable} is boolean type");
                }
                else if (char.TryParse(variable, out var value5))
                {
                    Console.WriteLine($"{variable} is character type");
                }
                else
                {
                    Console.WriteLine($"{variable} is string type");
                }

            }
        }
    }
}

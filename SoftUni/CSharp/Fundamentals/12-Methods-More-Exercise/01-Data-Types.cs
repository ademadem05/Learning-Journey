namespace _1._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string input = Console.ReadLine();
            DataTypes(command,input);
        }
        static void DataTypes(string type, string input) 
        {
            if (type == "int")
            {
                int result = int.Parse(input) * 2;
                Console.WriteLine(result);
            }
            else if (type == "real")
            {
                double result = double.Parse(input) * 1.5;
                Console.WriteLine($"{result:F2}"); 
            }
            else if (type == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }
      

    }
}

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "stop")
                {
                    break;
                }
                Console.WriteLine(userInput);
            }
            
        }
    }
}

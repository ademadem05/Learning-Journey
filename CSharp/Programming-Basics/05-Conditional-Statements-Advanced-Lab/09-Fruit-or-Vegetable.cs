namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice = Console.ReadLine(); 
            string[] Fruits = {"banana", "apple", "kiwi", "cherry", "lemon", "grapes"};
            string[] Vegtables = {"tomato", "cucumber", "pepper", "carrot"};
            if (!Fruits.Contains(userChoice) && !Vegtables.Contains(userChoice))
            {
                Console.WriteLine("unknown");
            }
            else
            {
                if (Fruits.Contains(userChoice))
                {
                    Console.WriteLine("fruit");  
                }
                else
                {
                    Console.WriteLine("vegetable");
                }
            }
        }
    }
}

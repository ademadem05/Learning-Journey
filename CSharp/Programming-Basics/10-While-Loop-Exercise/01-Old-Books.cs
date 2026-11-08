namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string BookWeSeek = Console.ReadLine();

            int bookCount = 0;
            while (true) 
            {
                string userInput = Console.ReadLine();
                

                if (userInput == BookWeSeek) 
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }

                

                if (userInput == "No More Books") 
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }

                bookCount++;
            }

        }
    }
}

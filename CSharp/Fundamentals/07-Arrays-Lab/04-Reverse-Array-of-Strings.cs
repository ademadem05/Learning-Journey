namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string userInput = Console.ReadLine();
            string[] arr = userInput.Split();

            string[] reversedArr = arr.Reverse().ToArray();
            foreach (var item in reversedArr)
            {
              Console.Write($"{item} ");  
            }
            
        }
    }
}


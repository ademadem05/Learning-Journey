using System.Globalization;

namespace _5._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                int mainDigit = int.Parse(numbers[0].ToString());

                if (mainDigit == 0) 
                {
                    message += " ";
                    continue;
                }

                int numberOfDigits = numbers.Length;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit >= 8)
                {
                    offset++;
                }

                int letterIndex = offset + numberOfDigits - 1;

                char letter = (char)(97 + letterIndex);
                message += letter;
            }
            Console.WriteLine(message);

        }
    }
}

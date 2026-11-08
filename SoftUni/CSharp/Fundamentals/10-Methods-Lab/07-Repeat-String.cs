namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(WordRepeater(word,times));
        }
        static string WordRepeater(string word, int times) 
        {
            string repeatedWord = "";
            for (int i = 0; i < times; i++)
            {
                repeatedWord += word;
            }
            return repeatedWord;
        }
    }
}

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
            Console.WriteLine(MiddileCharCollector(text));
        }
        static string MiddileCharCollector(string text) 
        {
            string evenCollector = string.Empty;
            string oddCollector  = string.Empty;
            int middle = text.Length / 2;
            if (text.Length % 2 == 0)
            {
                evenCollector += text.Substring(middle -1,2);
            }
            else
            {
                oddCollector += text.Substring(middle, 1);
            }

            if (evenCollector == "")
            {
                return oddCollector;
            }
            else
            {
                return evenCollector;
            }
        }
    }
}

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chr1 = char.Parse(Console.ReadLine());
            char chr2 = char.Parse(Console.ReadLine());
            CharsInRange(chr1, chr2);
        }
        static void CharsInRange(char chr1, char chr2) 
        {
            if (chr1 > chr2)
            {
               char temp = chr1;
               chr1 = chr2; 
               chr2 = temp;
            }
            for (int i = chr1 + 1; i < chr2; i++)
            {
                char Charakter = (char)i;
                Console.Write(Charakter + " ");
            }
        }
    }
}

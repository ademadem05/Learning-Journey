namespace _5._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n  = int.Parse(Console.ReadLine());

            string message = "";
            for (int i = 1; i <= n; i++)
            {
                char chracter = char.Parse(Console.ReadLine());

                char decryptedchar = (char)(chracter + key);

                message += decryptedchar;
            }
            Console.WriteLine(message);
        }
    }
}

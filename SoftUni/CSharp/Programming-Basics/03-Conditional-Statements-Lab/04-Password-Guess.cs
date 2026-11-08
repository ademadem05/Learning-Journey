namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main()
        {
            const string Phase = "s3cr3t!P@ssw0rd";

            string password = Console.ReadLine();

            if (Phase != password)
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}

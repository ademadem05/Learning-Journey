namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";
            int trys = 0;
            for (int i = username.Length -1; i >= 0; i--)
            {
                pass += username[i];
            }

            while (true) 
            {
                string password = Console.ReadLine();

                if (password != pass) 
                { 
                    trys++;

                    if (trys == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
            }
        }
    }
}

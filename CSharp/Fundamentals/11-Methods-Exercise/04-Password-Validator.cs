namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLengthValid = PassLengthCheck(password);
            bool isAlphaNumeric = IsPasswordValid(password);
            bool hasEnoughDigits = passwordDigitCheck(password);

            if (isLengthValid && isAlphaNumeric && hasEnoughDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool PassLengthCheck(string password)
        {
            if (!(6 <= password.Length && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            else
            {
                return true;
            }
                
        }
        static bool IsPasswordValid(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false; 
                }
            }
            return true;
        }
        static bool passwordDigitCheck(string password) 
        {
            int digitCount = 0;

            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    digitCount++;
                }
            }
            if (digitCount >= 2) 
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }
    }
}

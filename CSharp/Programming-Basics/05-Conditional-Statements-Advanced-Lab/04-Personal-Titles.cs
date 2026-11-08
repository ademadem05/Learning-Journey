namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	"Mr." – мъж(пол 'm') на 16 или повече години
            //•	"Master" – момче(пол 'm') под 16 години
            //•	"Ms." – жена(пол 'f') на 16 или повече години
            //•	"Miss" – момиче(пол 'f') под 16 години

            double Age = double.Parse(Console.ReadLine());
            string Gender = Console.ReadLine();


            if (Gender == "m")
            {
                if (Age >= 16) 
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");  
                }
            }
            else if (Gender == "f") 
            {
                if (Age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}

using System.Drawing;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main()
        {
            //square, rectangle, circle или triangle
            //Console.WriteLine("type a shape");
            string userInput = Console.ReadLine();

            if (userInput == "square") 
            {
                //Console.WriteLine("a");
                double N1 = double.Parse(Console.ReadLine());
                Console.WriteLine((Math.Pow(N1,2)).ToString("F3"));
                
            }
            else if(userInput == "rectangle")
            {
                //Console.WriteLine("a");
                double a = double.Parse(Console.ReadLine());
                //Console.WriteLine("b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b).ToString("F3"));
            }
            else if (userInput == "circle") 
            {
                //Console.WriteLine("r");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine((Math.PI * Math.Pow(radius, 2)).ToString("F3"));
            }
            else if(userInput == "triangle")
            {
                //Console.WriteLine("a");
                double a = double.Parse(Console.ReadLine());
                //Console.WriteLine("h");
                double h = double.Parse(Console.ReadLine());

                Console.WriteLine(((a * h) / 2).ToString("F3"));
            }
        }
    }
}

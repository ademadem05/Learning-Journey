namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine()); 
            string op = Console.ReadLine();

            if (op == "+")
            {
                int result = N1 + N2;
                string evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{N1} + {N2} = {result} - {evenOrOdd}");
            }
            else if (op == "-")
            {
                int result = N1 - N2;
                string evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{N1} - {N2} = {result} - {evenOrOdd}");
            }
            else if (op == "*")
            {
                double result = N1 * N2;
                string evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{N1} * {N2} = {result} - {evenOrOdd}");
            }
            else if (op == "/")
            {
                if (N2 == 0 || N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                     double result = (double)N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {result:F2}");
                }
               

                //string evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                
            }
            else if (op == "%") 
            {
                if (N2 == 0 || N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    int result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
                
                //string evenOrOdd = (result % 2 == 0) ? "even" : "odd";
                
            }

        }
    }
}

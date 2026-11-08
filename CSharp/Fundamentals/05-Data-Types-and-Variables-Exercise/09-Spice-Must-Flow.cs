namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int yield = 0 ;
            int day = 0;
            while (n>=100)
            {
                
                yield += (n - 26);
                day++;
                n -= 10;

                if (100 > n)
                {
                    yield -= 26;
                    break;
                }

                

            }
            Console.WriteLine(day);
            Console.WriteLine(yield);
        }
    }
}

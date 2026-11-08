namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }
        static long GetFibonacci(int n) 
        {

            long[] Array = new long[n];

            if (n <= 2)
            {
                return 1;
            }
            else
            {
               
                 return GetFibonacci(n -1) + GetFibonacci(n - 2) ;   
                
            }
            

        }
    }
}

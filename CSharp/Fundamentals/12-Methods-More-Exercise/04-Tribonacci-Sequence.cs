namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            Tribonacci(n);
        }
        static void Tribonacci(int n) 
        {

            if (0 > n)
            {
                return;
            }
            if (n >= 1) Console.Write(1 + " ");
            if (n >= 2) Console.Write(1 + " ");
            if (n >= 3) Console.Write(2 + " ");

            long a = 1;
            long b = 1;
            long c = 2;
            long nextNum = 0;
            int count = 3;
            
            for (int i = 0; count < n; i++)
            {

                 nextNum =  a + b + c;
                Console.Write(nextNum + " ");
                a = b;
                b = c;
                c = nextNum;
                nextNum = 0;
                count++;
                //int num = 1;
                //for (global::System.Int32 j = 0; num < i; j++)
                //{
                //    num += j;
                //}
                //Console.Write(num + " ");
            }
        }
    }
}

namespace _02.GreaterNumber
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Ilk girdi: ");
            double FirstNum = double.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci girdi: ");
            double SecondNum = double.Parse(Console.ReadLine());

            if (FirstNum > SecondNum)
            {
                Console.WriteLine(FirstNum);
            }
            else
            {
                Console.WriteLine(SecondNum);
            }
        }
    }
}

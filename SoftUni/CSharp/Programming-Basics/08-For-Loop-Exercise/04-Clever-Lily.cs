namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LilyAge = int.Parse(Console.ReadLine());    
            double priceOfWashmachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            int savings = 0;
            int toy = 0;
            int counter = 1;

            for (int i = 1; i <= LilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    savings += 10 * counter;
                    savings -= 1;
                    counter++;
                }
                else
                {
                    toy++;
                }
            }

            savings += toy * priceOfToy;

            if (savings >= priceOfWashmachine)
            {
                Console.WriteLine($"Yes! {(savings - priceOfWashmachine):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceOfWashmachine - savings):F2}");
            }
        }
    }
}

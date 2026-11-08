namespace _06.Repainting
{
    internal class Program
    {
        static void Main()
        {
            double naylon = 1.50;
            double paint = 14.50;
            double paintSep = 5.00;

            string? s_neededNaylon = Console.ReadLine();
            string? s_neededPaint = Console.ReadLine();
            string? s_neededPaintSep = Console.ReadLine();
            string? s_Hours = Console.ReadLine();

            if (
                string.IsNullOrWhiteSpace(s_neededNaylon) &&
                string.IsNullOrWhiteSpace(s_neededPaint) &&
                string.IsNullOrWhiteSpace(s_neededPaintSep) &&
                string.IsNullOrWhiteSpace(s_Hours)
                )
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                int neededNaylon = int.Parse(s_neededNaylon);
                int neededPaint = int.Parse(s_neededPaint);
                int neededPaintSep = int.Parse(s_neededPaintSep);
                int Hours = int.Parse(s_Hours);

                double priceOFNaylon = (neededNaylon + 2) * naylon;
                double priceOFPaint = ((neededPaint * 0.1) + neededPaint) * paint;
                double priceOFpaintSep = neededPaintSep * paintSep;
                double totalSum = priceOFNaylon + priceOFPaint + priceOFpaintSep + 0.40;
                double employeeMoney = (totalSum * 0.3) * Hours;
                double finalPrice = totalSum + employeeMoney;
                Console.WriteLine(finalPrice);
            }
        }
    }
}

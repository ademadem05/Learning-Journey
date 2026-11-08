namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string currnetModel = "";
            double totalKeg = 0;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double Keg = Math.PI * Math.Pow(radius, 2)  * height;
                if (Keg > totalKeg)
                {
                    totalKeg = Keg;
                    currnetModel = model;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(currnetModel);
        }
    }
}

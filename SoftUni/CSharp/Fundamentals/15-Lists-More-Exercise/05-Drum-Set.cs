using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            // Orijinal fiyatları saklamak için ilk listeyi okuyoruz
            List<int> initialDurability = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // Üzerinde işlem yapacağımız güncel dayanıklılık listesini kopyalıyoruz
            List<int> currentDurability = new List<int>(initialDurability);

            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);

                for (int i = 0; i < currentDurability.Count; i++)
                {
                    currentDurability[i] -= power;

                    if (currentDurability[i] <= 0)
                    {
                        // Satın alma maliyeti: Başlangıç fiyatı * 3
                        double price = initialDurability[i] * 3.0;

                        if (savings >= price)
                        {
                            savings -= price;
                            currentDurability[i] = initialDurability[i];
                        }
                        else
                        {
                            // Parası yetmiyorsa davul kırılır. 
                            // Listeden silmek yerine işaretleyip sonra temizlemek daha güvenlidir.
                            currentDurability[i] = 0; 
                        }
                    }
                }
            }

            // Kırılan davulları (0 olanları) listeden çıkarıyoruz
            var workingDrums = currentDurability.Where(d => d > 0).ToList();

            Console.WriteLine(string.Join(" ", workingDrums));
            // Fiyatlar Bulgaristan levası (lv) üzerinden istendiği için .2f formatı önemli
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
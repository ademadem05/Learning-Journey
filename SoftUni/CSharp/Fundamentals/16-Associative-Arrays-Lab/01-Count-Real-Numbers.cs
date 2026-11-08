using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayıları oku ve double listesine çevir
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            // SortedDictionary otomatik olarak anahtarları (sayıları) sıralar
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (double num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    // Sayı zaten varsa, mevcut adet değerini 1 artır
                    counts[num]++;
                }
                else
                {
                    // Sayı ilk kez geliyorsa, sözlüğe ekle ve adetini 1 yap
                    counts[num] = 1;
                }
            }

            // Sözlükteki her bir anahtar-değer ikilisini yazdır
            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
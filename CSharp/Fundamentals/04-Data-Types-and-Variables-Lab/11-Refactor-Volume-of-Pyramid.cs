using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Kural: Değişkenleri en üstte değil, kullanılacağı anda tanımlıyoruz (Span reduction).
            // 2. Kural: Anlamlı isimler kullanıyoruz (dul -> length, sh -> width).
            
            Console.Write("Length: "); 
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: "); 
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: "); 
            double height = double.Parse(Console.ReadLine());

            // 3. Kural: Bir değişkeni (V) birden fazla amaç için kullanmıyoruz. 
            // Hacim için yeni bir değişken (volume) oluşturuyoruz.
            // Ayrıca formülü toplamadan çarpmaya çevirerek düzeltiyoruz.
            
            double volume = (length * width * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
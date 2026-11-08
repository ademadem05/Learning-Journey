using System.Numerics;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени.

            //цвете Роза Далия Лале Нарцис Гладиола

            //Цена на брой в лева 5 3.80 2.80 3 2.50

            //Съществуват следните отстъпки:

            //· Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена

            //· Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена

            //· Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена

            //· Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %

            //· Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            //От конзолата се четат 3 реда:

            //· Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            //· Брой цветя -цяло число в интервала[10…1000]

            //· Бюджет - цяло число в интервала[50…2500]

            //Да се отпечата на конзолата на един ред:


            var Flowers = new Dictionary<string, double>() 
            {
                ["Roses"] = 5.00,
                ["Dahlias"] = 3.80,
                ["Tulips"] = 2.80,
                ["Narcissus"] = 3.00,
                ["Gladiolus"] = 2.50
            };

            string type = Console.ReadLine();   
            int flowerCount = int.Parse(Console.ReadLine());    
            int budget  = int.Parse(Console.ReadLine());
            double finalizator = 1.0;


                double totalPrice = Flowers[type] * flowerCount;



            // 2. Adjust the price based on conditions
            if (type == "Roses" && flowerCount > 80)
                totalPrice -= totalPrice * 0.10; // 10% off
            else if (type == "Dahlias" && flowerCount > 90)
                totalPrice -= totalPrice * 0.15; // 15% off
            else if (type == "Tulips" && flowerCount > 80)
                totalPrice -= totalPrice * 0.15; // 15% off
            else if (type == "Narcissus" && flowerCount < 120)
                totalPrice += totalPrice * 0.15; // 15% extra cost
            else if (type == "Gladiolus" && flowerCount < 80)
                totalPrice += totalPrice * 0.20; // 20% extra cost

            double FinalPrice = totalPrice * finalizator;

            if (budget >= FinalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {type} and {(budget - FinalPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(FinalPrice - budget):F2} leva more.");
            }



        }
    }
}

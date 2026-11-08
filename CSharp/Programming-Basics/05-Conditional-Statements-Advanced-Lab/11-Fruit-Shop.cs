using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //    плод banana apple orange grapefruit kiwi pineapple grapes

            //    цена 2.50   1.20   0.85   1.45      2.70    5.50    3.85

            //    Събота и неделя магазинът работи на по - високи цени:

            //плод banana apple orange grapefruit kiwi pineapple grapes

            //    цена 2.70 1.25 0.90   1.60       3.00  5.60    4.20

            var FruitTable = new Dictionary<string, double>()
            {
                ["banana"] = 2.50,
                ["apple"] = 1.20,
                ["orange"] = 0.85,
                ["grapefruit"] = 1.45,
                ["kiwi"] = 2.70,
                ["pineapple"] = 5.50,
                ["grapes"] = 3.85
            };

            var FruitTableWeekEnd = new Dictionary<string, double>()
            {
                ["banana"] = 2.70,
                ["apple"] = 1.25,
                ["orange"] = 0.90,
                ["grapefruit"] = 1.60,
                ["kiwi"] = 3.00,
                ["pineapple"] = 5.60,
                ["grapes"] = 4.20
            };

            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();  
            double amount = double.Parse(Console.ReadLine());

            switch (dayOfWeek) 
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (!FruitTable.ContainsKey(product))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        double totalPrice = FruitTable[product] * amount;
                        Console.WriteLine($"{totalPrice:F2}");
                    }

                        break;
                case "Saturday":
                case "Sunday":
                    if (!FruitTableWeekEnd.ContainsKey(product))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        double totalPrice = FruitTableWeekEnd[product] * amount;
                        Console.WriteLine($"{totalPrice:F2}");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }   
        }
    }
}

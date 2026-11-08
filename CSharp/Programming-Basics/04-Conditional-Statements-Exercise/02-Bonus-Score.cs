namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main()
        {
            //•	Ако числото е до 100 включително, бонус точките са 5.
            //•	Ако числото е по-голямо от 100 и по-малко или равно на 1000, бонус точките са 20 % от числото.
            //•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

            //•	Допълнителни бонус точки(начисляват се отделно от предходните):
            //o За четно число  +1 т.
            //o За число, което завършва на 5  +2 т.


            int UserNumber = int.Parse(Console.ReadLine());
            double points = 0;
            if (UserNumber % 2 == 0)
            {
                points+=1;
            }
            if (UserNumber % 10 == 5)
            {
                points+=2;
            }
            if (UserNumber <= 100) 
            {
                points += 5;
            }
            else if (100 < UserNumber && UserNumber <= 1000) 
            {
                points += UserNumber * 0.2;
            }
            else if(UserNumber > 1000) 
            {
                points += UserNumber * 0.1;
            }
            Console.WriteLine(points);
            Console.WriteLine(UserNumber + points);
        }

    }
}

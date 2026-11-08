namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                studio += 50 * nightsCount;
                apartment += 65 * nightsCount;
            }
            else if (month == "June" || month == "September")
            {
                studio += 75.20 * nightsCount;
                apartment += 68.70 * nightsCount;
            }
            else if (month == "July" || month == "August")
            {
                studio += 76 * nightsCount;
                apartment += 77 * nightsCount;
            }


            bool MayOrOctober = (month == "May" || month == "October");
            bool JuneOrSeptember = (month == "June" || month == "September");

            if (nightsCount > 14 && MayOrOctober)
            {
                studio *= 0.70;
                apartment *= 0.90;
            }
            else if (nightsCount > 14 && JuneOrSeptember)
            {
                studio *= 0.80;
                apartment *= 0.90; 
            }
            else if (nightsCount > 14 && (!MayOrOctober && !JuneOrSeptember))
            {
                apartment *= 0.90;
            }

            else if (nightsCount > 7 && MayOrOctober)
            {
                studio *= 0.95;
            }
           

            //if (nightsCount > 14 && (month == "May" || month == "October"))
            //{
            //    studio *= 0.70;
            //    apartment *= 0.90;
            //}
            //else if (nightsCount > 14 && (month == "June" || month == "September"))
            //{
            //    studio *= 0.80;
            //    apartment *= 0.90;
            //}

            //else if (nightsCount > 7 && nightsCount <= 14 && (month == "May" || month == "October"))
            //{
            //    studio *= 0.95;     
            //}
            //else
            //{
            //    apartment *= 0.90;
            //}


            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}

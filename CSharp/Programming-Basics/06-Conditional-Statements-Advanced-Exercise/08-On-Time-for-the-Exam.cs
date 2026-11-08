namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinute =int.Parse(Console.ReadLine());

            int examTotalTime = (examHour * 60) + examMinute;
            int arrivingTotalTime = (arrivingHour * 60) + arrivingMinute;

            int difference = examTotalTime - arrivingTotalTime;

            if (0 <= difference && 30 >= difference)
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }




            else if (difference < 0)
            {
                if (Math.Abs(difference) > 59)
                {
                    if ((Math.Abs(difference) % 60) < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Abs(difference) / 60}:0{Math.Abs(difference) % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrivingTotalTime - examTotalTime} minutes after the start");
                }

            }



            else if (difference > 30)
            {
                if (Math.Abs(difference) > 59)
                {
                    if (Math.Abs(difference) % 60 < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{difference / 60}:0{difference % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{difference / 60}:{difference % 60} hours before the start");
                    }


                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examTotalTime - arrivingTotalTime} minutes before the start");
                }

            }













            //if (arrivingTotalTime == examTotalTime)
            //{
            //    Console.WriteLine("On time");
            //}
            //else if (arrivingTotalTime < examTotalTime  && ((arrivingTotalTime - examTotalTime) <= 30))
            //{
            //    Console.WriteLine("On time");
            //    Console.WriteLine($"{examTotalTime - arrivingTotalTime} minutes before the start");
            //}
            //else if (arrivingTotalTime > examTotalTime)
            //{
            //    if ((arrivingTotalTime - examTotalTime) > 59)
            //    {
            //        double ArrHourParse = arrivingTotalTime / 60;
            //        double ArrMinuteParse = arrivingTotalTime % 60;

            //        Console.WriteLine("Late");
            //        Console.WriteLine($"{ArrHourParse:F1}:{ArrMinuteParse} hours after the start");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Late");
            //        Console.WriteLine($"{arrivingTotalTime - examTotalTime} minutes after the start");
            //    }
            //}

            //else if (arrivingTotalTime < examTotalTime)
            //{
            //    if ((arrivingTotalTime - examTotalTime) > 59)
            //    {
            //        double ArrHourParse = arrivingTotalTime / 60;
            //        double ArrMinuteParse = arrivingTotalTime % 60;

            //        Console.WriteLine("Early");
            //        Console.WriteLine($"{ArrHourParse}:{ArrMinuteParse} hours before the start");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Early");
            //        Console.WriteLine($"{arrivingTotalTime - examTotalTime} minutes before the start");
            //    }
            //}

        }
    }
}

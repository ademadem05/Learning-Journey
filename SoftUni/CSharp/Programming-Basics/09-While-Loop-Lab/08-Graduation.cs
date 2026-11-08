namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int BadGrade = 0;
            int counts = 0;
            double total = 0;
            while (true)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    BadGrade++;
                    
                    if (BadGrade > 1)
                    {
                      Console.WriteLine($"{name} has been excluded at {counts} grade");
                        break;  
                    }
                    counts++;
                    continue;
                }
                total += grade;
                counts++;

                if (counts >= 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(total / 12):F2}");
                    break;
                }

                
                

            }
           
        }
    }
}

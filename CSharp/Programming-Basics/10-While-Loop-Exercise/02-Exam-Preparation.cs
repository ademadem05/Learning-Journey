using static System.Formats.Asn1.AsnWriter;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double gradeTotal = 0;
            int total = 0;
            int badGrades = 0;
            string currentProblem = "";
            bool isFailed = false;

            int countBadgrades = int.Parse(Console.ReadLine());
            while (true)
            {
                string NameOFProblem = Console.ReadLine();

                if (NameOFProblem == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                gradeTotal += grade;
                total++;
                currentProblem = NameOFProblem;


                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades >= countBadgrades)
                    {
                        isFailed = true;
                        break;
                    }
                }
                


            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(gradeTotal/ total):F2}");
                Console.WriteLine($"Number of problems: {total}");
                Console.WriteLine($"Last problem: {currentProblem}");
            }
        }
    }
}




//4
//Stone Age
//5
//Freedom
//5
//Storage
//3
//Enough


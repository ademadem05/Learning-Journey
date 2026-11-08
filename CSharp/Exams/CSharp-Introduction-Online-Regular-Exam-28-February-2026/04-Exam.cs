namespace _04._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            double totalGrades = 0;
            int countOFStudent = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOFStudent; i++)
            {
                double gradeperStudent = double.Parse(Console.ReadLine());

                if (gradeperStudent < 3)
                {
                    group4++;
                    totalGrades += gradeperStudent;
                }
                else if (3 <= gradeperStudent && gradeperStudent <= 3.99 )
                {
                    group3++;
                    totalGrades += gradeperStudent;
                }
                else if (4 <=  gradeperStudent && gradeperStudent <= 4.99)
                {
                    group2++;
                    totalGrades += gradeperStudent;
                }
                else
                {
                    group1++;
                    totalGrades += gradeperStudent;
                }
            }
            double percentForTopStudens = (double)group1 / countOFStudent * 100;
            double percentFor4and4 = (double)group2 / countOFStudent * 100;
            double percentFor3and3 = (double)group3 / countOFStudent * 100;
            double percentForlow = (double)group4 / countOFStudent * 100;
            double average = totalGrades / countOFStudent;

            Console.WriteLine($"Top students: {percentForTopStudens:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentFor4and4:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentFor3and3:F2}%");
            Console.WriteLine($"Fail: {percentForlow:F2}%");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}

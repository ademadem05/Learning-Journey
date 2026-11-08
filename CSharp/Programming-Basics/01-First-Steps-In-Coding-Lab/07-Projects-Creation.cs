namespace CSharpLearning.Console
{
    internal class _07
    {
        static void Main()
        {
            string nameOfArchitect = System.Console.ReadLine();
            int numOfProjects = int.Parse(System.Console.ReadLine());
            int neededHours = numOfProjects * 3;

            System.Console.WriteLine($"The architect {nameOfArchitect} will need {neededHours} hours to complete {numOfProjects} project/s.");
        }
    }
}
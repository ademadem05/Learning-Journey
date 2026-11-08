namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalFootsteps = 10000;

            int currentSteps = 0;
            bool flag = false;
            while (true)
            {
                string Input = Console.ReadLine();
           

                if (Input == "Going home")
                {
                    int extraFootSteps = int.Parse(Console.ReadLine());
                    currentSteps += extraFootSteps;

                    if (currentSteps >= goalFootsteps)
                    {
                        flag = true;
                    }
                    break;
                }

                int step = int.Parse(Input);
                currentSteps += step;

                if (currentSteps >= goalFootsteps)
                {
                    flag = true;
                    break;
                }
            }
            if (flag) 
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{currentSteps - goalFootsteps} steps over the goal!");
            }
            else 
            {
                Console.WriteLine($"{goalFootsteps - currentSteps} more steps to reach goal.");
            }
        }
    }
}

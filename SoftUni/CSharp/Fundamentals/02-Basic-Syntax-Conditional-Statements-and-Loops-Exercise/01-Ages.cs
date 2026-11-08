namespace _1._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string person = "";
            if (0 <= age && age <= 2)
            {
                person = "baby";
            }
            else if (3 <= age && age <= 13)
            {
                person = "child";
            }
            else if (14 <= age && age <= 19)
            {
                person = "teenager";
            }
            else if (20 <= age && age <= 65)
            {
                person = "adult";
            }
            else
            {
                person = "elder"; 
            }
            Console.WriteLine(person);
        }
    }
}

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTickets = 0;
            double students = 0;
            double standard = 0;
            double kid = 0;
            while (true)
            {

                string nameOfMovie = Console.ReadLine();

                if (nameOfMovie == "Finish") 
                {
                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());
                int currentMovieTickets = 0;
                
       
                while (freeSeats > currentMovieTickets)
                {
                    string MovieName = Console.ReadLine();  
                    
                    if(MovieName == "End") { break; }

                    totalTickets++;
                    currentMovieTickets++;

                    if (MovieName == "standard" )
                    {
                        standard++;
                    }
                    else if (MovieName == "student")
                    {
                        students++;
                    }
                    else if (MovieName == "kid")
                    {
                        kid++;
                    }
                   
                }
                double occupancy = (double)currentMovieTickets / freeSeats * 100;
               Console.WriteLine($"{nameOfMovie} - {occupancy:F2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{((students / totalTickets) * 100):F2}% student tickets.");
            Console.WriteLine($"{((standard / totalTickets) * 100):F2}% standard tickets.");
            Console.WriteLine($"{((kid / totalTickets) * 100):F2}% kids tickets.");
        }
    }
}
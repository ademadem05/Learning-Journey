using System;

public class Program
{
    public static void Main()
    {
        // Input handling
        int n = int.Parse(Console.ReadLine()); // Starting Power
        int m = int.Parse(Console.ReadLine()); // Distance/Target Power
        int y = int.Parse(Console.ReadLine()); // Exhaustion Factor

        int originalN = n;
        int targetsPoked = 0;

        // Start the simulation
        while (n >= m)
        {
            n -= m;
            targetsPoked++;

            // Precise 50% check: 
            // We multiply N by 2 to see if it equals OriginalN 
            // (Alternative to N / OriginalN == 0.5)
            if (n * 2 == originalN && y != 0)
            {
                n /= y; // Integer division as required
            }
        }

        // Output results
        Console.WriteLine(n);
        Console.WriteLine(targetsPoked);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoldenTreasureQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder currentString = new StringBuilder();
            int commandsToSkip = 0;

            string input;
            while ((input = Console.ReadLine()) != "Error")
            {
                // Logic to handle the "Freeze" mechanic
                if (commandsToSkip > 0)
                {
                    commandsToSkip--;
                    continue;
                }

                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "Infuse")
                {
                    string characters = tokens[1];
                    currentString.Append(characters);
                    Console.WriteLine(currentString.ToString());
                }
                else if (command == "Transpose")
                {
                    int idx1 = int.Parse(tokens[1]);
                    int idx2 = int.Parse(tokens[2]);

                    if (idx1 >= 0 && idx1 < currentString.Length && idx2 >= 0 && idx2 < currentString.Length)
                    {
                        char temp = currentString[idx1];
                        currentString[idx1] = currentString[idx2];
                        currentString[idx2] = temp;
                        Console.WriteLine(currentString.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Failed attempt to unlock the treasure");
                    }
                }
                else if (command == "Retrace")
                {
                    int index = int.Parse(tokens[1]);
                    // Extract substring from 0 to index (inclusive)
                    string partToReverse = currentString.ToString().Substring(0, index + 1);
                    char[] charArray = partToReverse.ToCharArray();
                    Array.Reverse(charArray);
                    
                    string reversedPart = new string(charArray);
                    currentString.Remove(0, index + 1);
                    currentString.Insert(0, reversedPart);
                    
                    Console.WriteLine(currentString.ToString());
                }
                else if (command == "Destroy")
                {
                    char target = char.Parse(tokens[1]);
                    string currentContent = currentString.ToString();

                    if (currentContent.Contains(target))
                    {
                        currentString.Replace(target.ToString(), "");
                        Console.WriteLine(currentString.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"Character {target} is invalid");
                    }
                }
                else if (command == "Freeze")
                {
                    commandsToSkip = 2;
                }

                // Check if we matched the password early
                if (currentString.ToString() == password)
                {
                    break;
                }
            }

            // Final Result
            if (currentString.ToString() == password)
            {
                Console.WriteLine("The Golden Treasure has been unlocked!");
            }
            else
            {
                Console.WriteLine($"The string {currentString} does not match the password {password}!");
            }
        }
    }
}
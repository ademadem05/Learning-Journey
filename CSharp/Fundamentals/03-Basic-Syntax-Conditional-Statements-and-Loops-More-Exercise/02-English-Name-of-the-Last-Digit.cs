using System;
using System.Collections.Generic;

// Namespace'i tamamen sildik
public class Program
{
    public static void Main()
    {
        var numsSpell = new Dictionary<int, string>()
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"}
        };

        string userInput = Console.ReadLine();
        
        // Boş giriş kontrolü
        if (string.IsNullOrEmpty(userInput)) return;

        // Son karakteri sayıya çevir
        int lastDigit = (int)Char.GetNumericValue(userInput[userInput.Length - 1]);

        // Dictionary'den karşılığını yazdır
        if (numsSpell.ContainsKey(lastDigit))
        {
            Console.WriteLine(numsSpell[lastDigit]);
        }
    }
}
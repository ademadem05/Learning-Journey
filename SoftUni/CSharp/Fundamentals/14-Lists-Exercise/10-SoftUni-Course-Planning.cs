using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedul = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                if (string.IsNullOrEmpty(input)) continue;

                string[] tokens = input.Split(':').ToArray();
                string command = tokens[0];
                string lessonTitle = tokens[1];

                if (command == "Add")
                {
                    if (!initialSchedul.Contains(lessonTitle))
                    {
                        initialSchedul.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    if (!initialSchedul.Contains(lessonTitle))
                    {
                        if (index >= 0 && index <= initialSchedul.Count)
                        {
                            initialSchedul.Insert(index, lessonTitle);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    if (initialSchedul.Contains(lessonTitle))
                    {
                        initialSchedul.Remove(lessonTitle);
                        string exerciseName = $"{lessonTitle}-Exercise";
                        if (initialSchedul.Contains(exerciseName))
                        {
                            initialSchedul.Remove(exerciseName);
                        }
                    }
                }
                else if (command == "Swap")
                {
                    string subject1 = lessonTitle;
                    string subject2 = tokens[2];

                    if (initialSchedul.Contains(subject1) && initialSchedul.Contains(subject2))
                    {
                        int index1 = initialSchedul.IndexOf(subject1);
                        int index2 = initialSchedul.IndexOf(subject2);

                        // 1. Dersleri Yer Değiştir
                        string temp = initialSchedul[index1];
                        initialSchedul[index1] = initialSchedul[index2];
                        initialSchedul[index2] = temp;

                        // 2. Egzersizleri Kontrol Et ve Yeni Yerlerine Taşı (Kural gereği)
                        if (initialSchedul.Contains($"{subject1}-Exercise"))
                        {
                            initialSchedul.Remove($"{subject1}-Exercise");
                            int newIdx = initialSchedul.IndexOf(subject1);
                            initialSchedul.Insert(newIdx + 1, $"{subject1}-Exercise");
                        }

                        if (initialSchedul.Contains($"{subject2}-Exercise"))
                        {
                            initialSchedul.Remove($"{subject2}-Exercise");
                            int newIdx = initialSchedul.IndexOf(subject2);
                            initialSchedul.Insert(newIdx + 1, $"{subject2}-Exercise");
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string exerciseName = $"{lessonTitle}-Exercise";
                    if (initialSchedul.Contains(lessonTitle))
                    {
                        if (!initialSchedul.Contains(exerciseName))
                        {
                            int index = initialSchedul.IndexOf(lessonTitle);
                            initialSchedul.Insert(index + 1, exerciseName);
                        }
                    }
                    else
                    {
                        initialSchedul.Add(lessonTitle);
                        initialSchedul.Add(exerciseName);
                    }
                }
            }

            // ÇIKTI DÖNGÜSÜ: 0'dan başlıyoruz, Count'a kadar gidiyoruz.
            for (int i = 0; i < initialSchedul.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialSchedul[i]}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Console
{
    internal class _06
    {
        static void Main()
        {
            string firstName = System.Console.ReadLine();
            string lastName = System.Console.ReadLine();
            int age = int.Parse(System.Console.ReadLine());
            string town = System.Console.ReadLine();
            System.Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
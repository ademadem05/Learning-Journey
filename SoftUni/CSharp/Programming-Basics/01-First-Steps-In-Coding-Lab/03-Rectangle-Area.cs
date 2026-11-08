using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Console
{
    internal class Rectangle_Area
    {
        static void Main()
        {   
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());

            int area = a * b;
            System.Console.WriteLine(area);
        }
    }
}
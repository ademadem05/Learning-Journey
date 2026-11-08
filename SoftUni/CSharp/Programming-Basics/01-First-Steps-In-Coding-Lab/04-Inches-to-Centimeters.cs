using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Console
{
    internal class _04
    {
        static void Main()
        {
            double OneInch = 2.54;
            //System.Console.WriteLine("Enter inches:");
            double userInput= double.Parse(System.Console.ReadLine());
            double centimeters = userInput * OneInch;

            System.Console.WriteLine(centimeters);
        }
    }
}

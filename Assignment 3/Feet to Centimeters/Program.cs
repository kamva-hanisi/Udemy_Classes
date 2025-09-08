using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feet_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int feet = 5;

            int inches = 7;

            // convert feet to inches

            int totalInches = (feet * 12) + inches;

            // convert inches to centimeters

            double centimeters = totalInches * 2.54;

            System.Console.WriteLine("The height in centimeters is: " + centimeters);

            System.Console.ReadLine();
        }
    }
}

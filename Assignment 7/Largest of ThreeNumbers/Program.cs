using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_of_ThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 60;
            int num2 = 45;
            int num3 = 123;
            int largest;

            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }

            Console.WriteLine("The largest number is: " + largest);

            Console.ReadLine();

        }
    }
}

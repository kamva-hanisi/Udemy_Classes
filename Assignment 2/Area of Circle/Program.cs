using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            double radius = 5.0;

            double area = PI * radius * radius;

            System.Console.WriteLine("The area of circle is: " + area);

            System.Console.ReadKey();
        }
    }
}

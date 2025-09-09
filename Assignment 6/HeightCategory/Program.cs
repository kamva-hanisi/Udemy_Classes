using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inches = 75;

            double cm = inches * 2.54;

            if (cm < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (cm >= 150 && cm < 165)
            {
                Console.WriteLine("Average height");
            }
            else if (cm >= 165 && cm < 195)
            {
                Console.WriteLine("Tall");
            }
            else if (cm >= 165 && cm < 195)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }

             Console.ReadLine(); 
        }
    }
}

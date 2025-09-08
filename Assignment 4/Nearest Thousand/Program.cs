using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Thousand
{
    internal class Program
    {
        static void Main(string[] args)
    
        {
            // testing numbers
            int[] numbers = { 499, 500, 999, 1000, 1499, 1500 };

            foreach (int num in numbers)
            {
                int rounded;

                if (num < 500)
                {
                    rounded = 1000;
                }
                else
                {
                    int remainder = num % 1000;
                    int baseValue = num / 1000;

                    if (remainder >= 500)
                    {
                        rounded = (baseValue + 1) * 1000;
                    }
                    else
                    {
                        rounded = baseValue * 1000;
                    }
                }

                System.Console.WriteLine($"Input: {num} Output: {rounded}");

                System.Console.ReadLine();

            }
        }
    }
}

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
            //int[] numbers = { 499, 500, 999, 1000, 1499, 1500 };

            int number = 499;

            decimal decimal_number = number;
            
            int previous_thousand = number / 1000 * 1000;

             
            decimal last_three_digits_x = decimal_number / 1000;
            decimal last_three_digits_y = number / 1000;

            decimal last_three_digits = (last_three_digits_x - last_three_digits_y) * 1000;

            
            int rounding_value = (last_three_digits >= 500) ? 1000 : 0;

            int is_less_than_five_hundred = (number < 500) ? 1000 : 0;

            int nearest_thousand = previous_thousand + rounding_value + is_less_than_five_hundred;
            System.Console.WriteLine(nearest_thousand);
            System.Console.ReadKey();

        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSeconds_into_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSeconds = 288970;

            int days = totalSeconds / 86400;
            int hours = (totalSeconds % 86400) / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            System.Console.WriteLine($"{days} days, {hours} hours, {minutes} minutes, {seconds} seconds");

            System.Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continue 1 to 10

            for (int i = 1; i <= 10;i++)
            {
                if (i == 5)
                {
                continue;
                }
                if (i == 6)
                {
                    continue;
                }

                Console.Write(i+" ");
            }
            Console.WriteLine();

            // Continue 1 to 10

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 6)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Continue 1 to 10

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 6)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 10 to 1

            for (int j=10;j>=1;j-- )
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();

            // 10 to 1

            for (int j = 10; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

            // break 10 to 3

            for (int i=10;i>0;i--)
            {
                if (i==2)
                {
                    break;
                }
                Console.Write(i+" ");
            }
            Console.WriteLine();

            // 10 to 1

            for (int j = 10; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

            // Continue 1 to 10

            for (int i = 1; i <= 10; i++)
            {
                if (i==8)
                {
                    continue;
                }
                Console.Write(i+" ");
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}

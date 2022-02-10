using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project6
{
   
        /*****************************************************************
         * Author:Sudha Kumari Sugasani
         * Purposse:Program to print the first number after 1000 which is
         *          divisible by 97 using break and for loop
         * ***************************************************************/
        class Divisible
        {
            /// <summary>
            /// This method will print the number which is divisible by 97
            /// </summary>
            public void PrintNumbers()
            {
                int i;
               
                for (i = 1000; i <= 1097; i++)
                {
                    if (i % 97 == 0)
                    {

                    Console.WriteLine($"First number which is divisble by 97 is {i}");
                    break;
                    }
                }

            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Divisible d1=new Divisible();
                d1.PrintNumbers();
                Console.ReadLine();
            }
        }
    }


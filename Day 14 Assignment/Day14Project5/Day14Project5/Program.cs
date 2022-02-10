using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project5
{
        /*****************************************************************
         * Author:Sudha Kumari Sugasani
         * Purposse:Program to print the number from 1 to 30 and skip the 
         *          numbers which are divisible by 3 using continue
         * ***************************************************************/
        class Numbers
        {
            /// <summary>
            /// This method will print numbers from 1 to 30
            /// </summary>
            public void PrintNumbers()
            {
            int i;
            Console.WriteLine("The number between 1 and 30 which are not divisble by 3 are ");
                for (i = 1; i <=30; i++)
                {
                    if (i%3 == 0)
                       continue;
                Console.WriteLine(i);
                }
                
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Numbers n1=new Numbers();
                n1.PrintNumbers();
                Console.ReadLine();
            }
        }
    }


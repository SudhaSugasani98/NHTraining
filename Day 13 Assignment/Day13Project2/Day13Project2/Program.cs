using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project2
{
   /****************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose: Declaration and intialisation  of 2 dimensional array 
     *          in same line of size(3x2),print the values using 
     *          nested for loop
     * ***************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 5, 6 }, { 48, 18 }, { 56, 78 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
    
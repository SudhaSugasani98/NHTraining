using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    /********************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program for recursion
     * *****************************************/
    internal class Program
    {
        /// <summary>
        /// It will return factorial of a number
        /// </summary>
        /// <param name="n">5</param>
        /// <returns>int</returns>
        static int Factorial(int n)
        {
            if(n== 0)
                return 1;
            else
                return n*Factorial(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial of given number is {Factorial(5)}") ;
            Console.ReadLine();

        }
    }
}

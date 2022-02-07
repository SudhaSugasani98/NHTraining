using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project5
{
    /**************************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Creating a Mathematics class with three static methods and call 
     *         them in main method.
     * ************************************************************************/
    class Mathematics
    {
        /// <summary>
        /// This is a static method 
        /// It will return Sum of two numbers 
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>Sum</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// This is a static method
        /// It will return difference of two numbers
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>Diifference</returns>
        public static int Sub(int a,int b)
        {
            return a - b;
        }
        /// <summary>
        /// This is a static method
        /// It will return product of two numbers
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>Product</returns>
        public static int Mul(int a,int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The sum of two numbers is {Mathematics.Add(2,3)}");
            Console.WriteLine($"The difference of two numbers is {Mathematics.Sub(15, 10)}");
            Console.WriteLine($"The product of two numbers is {Mathematics.Mul(2, 3)}");
            Console.ReadLine();
        }
    }
}

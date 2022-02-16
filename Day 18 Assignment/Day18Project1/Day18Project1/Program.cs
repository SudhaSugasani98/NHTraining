using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicsLibrary;

namespace Day18Project1
{
    /***********************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:By using the MathematicsLibrary creating console application.
     * **********************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The factorial value of {n} is {Algebra.Factorial(n)}");
            Console.ReadLine();
        }
    }
}

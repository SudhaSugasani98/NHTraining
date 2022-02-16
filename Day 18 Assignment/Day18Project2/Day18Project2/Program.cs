using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicsLibrary1;

namespace Day18Project2
{
    /***************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Using MathematicsLibrary1 in consoleapp
     * **************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {n} is {Algebra.Factorial(n)}");
            Console.ReadLine();
        }
    }
}

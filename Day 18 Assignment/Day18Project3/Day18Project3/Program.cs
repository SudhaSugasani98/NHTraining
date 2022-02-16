using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicsLibrary2;

namespace Day18Project3
{
    internal class Program
    {
        /***************************************************
          * Author:Sudha Kumari Sugasani
          * Purpose:Using MathematicsLibrary2 in consoleapp
          * **************************************************/

        static void Main(string[] args)
        {
            //Algebra palindrome = new Algebra();
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {n} is {Algebra.Factorial(n)}");
            int input;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Algebra.isPalindromeorNot(input) ); 
            Console.ReadLine();

        }
    }
}

using Day21Project1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Project1
{
    /***************************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program to create webservice for Mathematical Operations
     * **************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine($"The factorial of given numer is {obj.Factorial(5)}");
            Console.WriteLine($"The sum of numbers is {obj.Add(5,6)}");
            Console.WriteLine($"Product of numbers is {obj.Mul(5,6)}");
            Console.ReadLine();

        }
    }
}

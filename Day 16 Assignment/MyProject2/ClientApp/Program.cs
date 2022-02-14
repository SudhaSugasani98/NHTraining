using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudhaSLibrary;

namespace ClientApp
{
    /**************************************
     * Author:Sudha Sugasani
     * Purpose:Example for Partial class
     * *************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m1 = new Mathematics();
            Console.WriteLine($"The Sum of two numbers is {m1.Add(5,10)}");
            Console.WriteLine($"The difference of two numbers is {m1.Sub(10,5)}");
            Console.WriteLine($"The Product of two number is {m1.Mul(2,3)}");
            Console.WriteLine($"Division of two numbers is {m1.Division(24,6)}");
            Console.WriteLine($"Modular division of two numbers is {m1.ModularDivision(27,5)}");
            Console.ReadLine();
        }
    }
}

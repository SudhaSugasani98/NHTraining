using System;
using SudhaSugasaniLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project3
{
   /******************************************************************
    * Author:Sudha Kumari Sugasani
    * Purpose:Program to refer library classes in console application
    * ****************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m1 = new Mathematics();
            m1.Readdata();
            Console.WriteLine($"Factorial of given number is {m1.GetFactorial()}");
            Console.WriteLine($"The formula for Benzene is {Chemistry.GetBenzene()}");
            Console.WriteLine($"The formula for Water is {Chemistry.GetWater()}");
            Console.WriteLine($"The formula for Methane is {Chemistry.GetMethane()}");
            Console.WriteLine($"Final Velocity is {Physics.FinalVelocity(5,10,15)}");
            Console.ReadLine();
        }
    }
}

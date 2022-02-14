 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudhaLibrary;
using PublicLibrary;

namespace ClientApp
{
    /*******************************************************
     * Author:Sudha Sugasani
     * Purpose:Creating a class(clientapp) and refering 
     *         libraries(SudhaLibrary,PublicLibrary) in it
     * *****************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of two numbers is {Mathematics.Add(5,10)}");
            Console.WriteLine($"Product of two numbers is {Mathematics.Mul(5,2)}");
            Console.WriteLine($"The division of two numbers is {Mathematics.Div(10,5)}");
            Console.WriteLine($"Moduluar division of two numbers is {Mathematics.ModDiv(20,11)}");
            Console.WriteLine($"Speed is {Physics.Speed(15,5)}");
            Console.ReadLine();
        }
    }
}

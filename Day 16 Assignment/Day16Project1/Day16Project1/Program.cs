using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project1
{
    /*******************************************************
     *Author:Sudha Kumari Sugasani
     *Purpose:Program to print Hello in object oriented way 
     * *****************************************************/
    class Hello
    {
        /// <summary>
        /// This method is used to print Hello
        /// </summary>
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello.PrintHello();
            Console.ReadLine();
        }
    }
}

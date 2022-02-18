using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project2
{ 
        /**********************************************
         * Author:Sudha Sugasani
         * Purpose:Example program for Nullable types
         * ********************************************/
    class NullableTypes1
    {
         byte?  input = null;
        /// <summary>
        /// The method will check if the input has value or not
        /// </summary>
        public void Check()
        {
            if(input.HasValue)
            {
                Console.WriteLine($"The output of {input} is {input*input}");
            }
            else
            {
                Console.WriteLine("No Value");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NullableTypes1 obj = new NullableTypes1();
            obj.Check();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project3
{
    /******************************************************
     * Author:Sudha Sugasani
     * Purpose:Example program for ref,out type parameters
     * ****************************************************/
    class TypesOfParameters
    {
        /// <summary>
        /// This method will tell give the Example for Out type parameter
        /// </summary>
        /// <param name="a">int</param>
        public static void ExampleforOut(out int a)
        {
            a= 80;
            a*= a;
        }
        /// <summary>
        /// This method will tell give the Example for Ref type parameter
        /// </summary>
        /// <param name="s1">String</param>
        public static void ExampleforRef(ref string s1)
        { 
            if (s1 == "Hello")
            {
                Console.WriteLine("Hello!,It is correct");
            }
            s1 = "Hai";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            TypesOfParameters.ExampleforOut(out a);
            Console.WriteLine($"Out:The product Of the value is {a}" );
            
            string s2 = "Hello";

            
            TypesOfParameters.ExampleforRef(ref s2);

            
            Console.WriteLine($"After assigning value to Ref:{s2}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10project1
{
    namespace Day10project1
    {
        /*****************************************************
         * Author:Sudha Sugasani
         * Purpose:Example code for Single Inheritance,         
         *****************************************************/
        class Algebra
        {
            /// <summary>
            /// This method do addition of two numbers
            /// </summary>
            /// <param name="a">int</param>
            /// <param name="b">int</param>
            /// <returns>sum</returns>
            public int Add(int a, int b)
            {
                return a + b;
            }
            /// <summary>
            /// This method do Substraction of two numbers
            /// </summary>
            /// <param name="a">int</param>
            /// <param name="b">int</param>
            /// <returns>difference</returns>
            public int Sub(int a, int b)
            {
                return a - b;
            }
        }
        class Totalmaths : Algebra
        {
            /// <summary>
            /// This method do Multiplication of two numbers
            /// </summary>
            /// <param name="a">int</param>
            /// <param name="b">int</param>
            /// <returns>Product</returns>
            public int Mul(int a, int b)
            {
                return (a * b);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Totalmaths t1 = new Totalmaths();
                Console.WriteLine($"The Sum of two numbers is {t1.Add(10, 15)}");
                Console.WriteLine($"The difference between two numbers is {t1.Sub(15, 10)}");
                Console.WriteLine($"The product of two numbers is {t1.Mul(10, 5)}");
                Console.ReadLine();

            }
        }


    }

}
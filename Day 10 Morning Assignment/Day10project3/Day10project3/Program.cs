using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10project3
{
        /*****************************************************
         * Author:Sudha Sugasani
         * Purpose:Example code for Method Overloading        
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
            /// This method do addition  of three numbers
            /// </summary>
            /// <param name="a">int</param>
            /// <param name="b">int</param>
            /// <returns>sum</returns>
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            /// <summary>
            /// This method do addition of four numbers
            /// </summary>
            /// <param name="a">int</param>
            /// <param name="b">int</param>
            /// <param name="c">int</param>
            /// <param name="d">int</param>
            /// <returns>sum</returns>
            public int Add(int a, int b, int c, int d)
            {
                return a + b + c + d;
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Algebra a1 = new Algebra();
                Console.WriteLine($"The Sum of two numbers is {a1.Add(10, 15)}");
                Console.WriteLine($"The Sum of three numbers is {a1.Add(15, 10, 20)}");
                Console.WriteLine($"The Sum of four numbers is {a1.Add(10, 15, 5, 20)}");
                Console.ReadLine();

            }
        }


    }

   
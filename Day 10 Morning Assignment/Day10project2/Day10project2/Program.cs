using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10project2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   
            /*****************************************************
             * Author:Sudha Sugasani
             * Purpose:Example code for Multilevel Inheritance,         
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
           class Allsubjects:Totalmaths
            {
                /// <summary>
                /// This method will return formula for Methane
                /// </summary>
                /// <returns>CH4</returns>
               public string Water()
                {
                    return "H2O";
                 }
             }

            internal class Program
            {
                static void Main(string[] args)
                {
                    Allsubjects a1 = new Allsubjects();
                    Console.WriteLine($"The Sum of two numbers is {a1.Add(10, 15)}");
                    Console.WriteLine($"The difference between two numbers is {a1.Sub(15, 10)}");
                    Console.WriteLine($"The product of two numbers is {a1.Mul(10, 5)}");
                    Console.WriteLine($"Formula for Methane is {a1.Water()}");
                    Console.ReadLine();

                }
            }


        }

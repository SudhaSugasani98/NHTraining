using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9project2
{

        /*********************************************************************
         * Author:Sudha Sugasani
         * Purpose:Program to find sum of two numbers,difference of two numbers,
         *         product of two numbers,division of two numbers
         * *******************************************************************/

        class MathsTask
        {
            private int input1;
            private int input2;

            /// <summary>
            /// This method will read input from user.
            /// </summary>

            public void Readinput()
            {
                Console.WriteLine("Enter  first number");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                input2 = Convert.ToInt32(Console.ReadLine());
             }

            /// <summary>
            /// This method will find Addition of two numbers and prints it
            /// </summary>
            /// <returns>sum</returns>
            public int Addition()
            {
                int sum;
                sum=input1+input2;
                return sum;
            }

            /// <summary>
            /// This methods will find Difference of  two numbers
            /// </summary>

            public void Difference()
            {
                 int Difference;
                Difference = input1 - input2;
            Console.WriteLine($"The Difference of two numbers are {Difference}");

            }

        /// <summary>
        /// This method will find the product of two numbers
        /// </summary>
        /// <returns>Product</returns>
             public int Product()
             {
            int Product;
            Product = input1 * input2;
            return Product;
             }

        /// <summary>
        /// This methods will find Division of  two numbers
        /// </summary>
          public void Division()
          {
            int Division;
            Division= input1 / input2;
            Console.WriteLine($"Division is {Division}");
          }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                MathsTask obj = new MathsTask();
                obj.Readinput();
                Console.WriteLine($"Addition of two numbers is {obj.Addition()}");
                obj.Difference();
               Console.WriteLine($"Product of two numbers is {obj.Product()} ");
               obj.Division();
                Console.ReadLine();
            }
        }
    }
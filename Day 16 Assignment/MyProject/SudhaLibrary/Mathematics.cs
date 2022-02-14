using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaLibrary
{
    /******************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Creating Sudha library adding classes and methods in it
     * ****************************************************************/
    public static class Mathematics
    {
        /// <summary>
        /// This method will give sum of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>sum(int)</returns>
        public static int Add(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// This method will give product of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Product(int)</returns>
        public static int Mul(int a,int b)
        {
            return a * b;
        }
        /// <summary>
        /// This method will return division of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Div(int)</returns>
        public static int Div(int a,int b)
        {
            return a / b;
        }
        /// <summary>
        /// This method will return Modular division of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>ModularDivision(int)</returns>
        public static int ModDiv(int a,int b)
        {
            return a % b;
        }
    }
}

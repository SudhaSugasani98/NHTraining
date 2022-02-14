using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaSLibrary
{
    /*************************************************
     * Author:Sudha Sugasani
     * Purpose:Example for partial class
     * ***********************************************/
    public partial class Mathematics
    {
        /// <summary>
        /// This method will return the sum of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Sum(int)</returns>
        public int Add(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// This method will return difference of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Difference(int)</returns>
        public int Sub(int a,int b)
        {
            return a - b;
        }
        /// <summary>
        /// This method will return Product of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>product(int)</returns>
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
}

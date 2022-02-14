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
        /// This method will return Division of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Division(int)</returns>
        public int Division(int a,int b)
        {
            return a / b;
        }
        /// <summary>
        /// This method will return ModularDivision of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>ModularDivision(int)</returns>
        public int ModularDivision(int a,int b)
        {
            return a % b;
        }
    }
}

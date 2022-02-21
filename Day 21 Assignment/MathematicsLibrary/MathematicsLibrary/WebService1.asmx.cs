using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathematicsLibrary
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        /// <summary>
        /// This method will return factorial
        /// </summary>
        /// <param name="n">int</param>
        /// <returns>Fact(int)</returns>
        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1,i;
            for(i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;

        }
        /// <summary>
        /// This method will return sum of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Sum(int)</returns>
        [WebMethod]
        public int Add(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// This method will return Product of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>Product(int)</returns>
        [WebMethod]
        public int Mul(int a,int b)
        {
            return a*b;
        }

    }
}

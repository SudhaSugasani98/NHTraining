using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaSugasaniLibrary
{
    public class Mathematics
    {
        int input;
        /// <summary>
        ///This method will read input from user
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("Enter input");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method will return factorial of a number
        /// </summary>
        /// <returns>factorial(int)</returns>
        public int GetFactorial()
        {
            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    /*******************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Program to read a number from user and print
     *         factorial of it
     * *****************************************************/
    class Mathematics
    {
        int input;
        /// <summary>
        ///This method will read input from user
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("Enter input");
            input=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method will return factorial of a number
        /// </summary>
        /// <returns>factorial</returns>
        public int GetFactorial()
        {
            int factorial = 1;
            for(int i = 1; i <=input;i++)
            {
                factorial=factorial*i;
            }
            return factorial;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics obj=new Mathematics();
            obj.Readdata();
            Console.WriteLine($"Factorial of given number is {obj.GetFactorial()}");
            Console.ReadLine();
        }
    }
}

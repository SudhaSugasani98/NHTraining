using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project5
{ 
    /******************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Program to check given umber is Palindrome 
     *         not in Object Oriented Way
     * ****************************************************/
    class Palindrome
    {
          int input;
        /// <summary>
        /// Read data from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Checking the given number is Palindrome or not
        /// </summary>
        public void CheckPalindromeorNot()
        {
            int n, rem = 0, rev = 0;
            n = input;
            while(n>0)
            {
                rem = n % 10;
                n = n / 10;
                rev = rev * 10 + rem;
            }
            if(input==rev)
            {
                Console.WriteLine($"{input} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is not a Palindrome");
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p1 = new Palindrome();
            p1.ReadData();
            p1.CheckPalindromeorNot();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and read data from user
 
             int input;
            int m, rem;
            int rev = 0;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic and Output
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (input == rev)

                Console.WriteLine("{0} is a Palindrome", input);
            else
                Console.WriteLine("{0} is not a Palindrome", input);
            Console.ReadLine();
        }
    }
}

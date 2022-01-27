using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits_of_a_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and read data from user
            int input;
            int m, rem;
            int result = 0;
            Console.WriteLine("Enter a number");
            input=Convert.ToInt32(Console.ReadLine());

            //Logic
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem ;
            }

            //Output
            Console.WriteLine("Sum of the digits of {0} is {1}",input,result);
            Console.ReadLine();
        }
    }
}

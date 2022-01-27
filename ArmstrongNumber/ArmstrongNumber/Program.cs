using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
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

            //Logic and Output
            m = input;
            while(m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem *rem * rem;
            }
            if(result==input)
                Console.WriteLine("{0} is a Armstrong number",input);
            else
                Console.WriteLine("{0} is  not a Armstrong number", input);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable decalaration and reading the input
            int input;
           
            Console.WriteLine("Enter a number");
            input=Convert.ToInt32(Console.ReadLine());

            //Logic and printing output
            int i;
            for( i = 2; i < input; i++)
            {
                if(input%i==0)
                {
                    break;
                }   

            }
            if(i==input)
            {
                Console.WriteLine("{0} is a prime number", input);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", input);
                Console.ReadLine();
            }

        }
    }
}

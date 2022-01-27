using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input;
            int fact=1;

            //Read data from user
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());


            //Logic
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }


            //Output
            Console.WriteLine("The factorial of {0} is {1}",input,fact);
            Console.ReadLine();
        }
    }
}

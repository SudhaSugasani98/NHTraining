using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialusingrecurssion
{
    internal class Program
    {
         
        
        static void Main(string[] args)
        {
            int n; 
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Factorial of {0} is {1}",n,Factorial(n));
            Console.ReadLine();
        }
        static int Factorial(int input)
        {
            if (input == 0)
                return 1;
            else
                return input * Factorial(input - 1);
        }
        
    }
}

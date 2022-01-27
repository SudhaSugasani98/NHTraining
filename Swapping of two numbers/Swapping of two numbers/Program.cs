using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and read data from user
            int input1,input2,t;
            Console.WriteLine("Enter first number");
            input1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            input2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers {0} {1} before Swapping",input1,input2);
            Console.ReadLine();

            //Logic and Output
            t = input1;
            input1 = input2;
            input2 = t;
            Console.WriteLine("The numbers {0} {1} after Swapping", input1, input2);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofNnaturalnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input;
            int Sum = 0;

            //Read data from user
            Console.WriteLine("Enter any number");
            input=Convert.ToInt32(Console.ReadLine());


            //Logic
            for(int i=1;i<=input;i++)
            {
                Sum=Sum+i;
            }


            //Output
            Console.WriteLine("Sum of {0} natural numbers is {1}",input,Sum);
            Console.ReadLine();
        }
    }
}

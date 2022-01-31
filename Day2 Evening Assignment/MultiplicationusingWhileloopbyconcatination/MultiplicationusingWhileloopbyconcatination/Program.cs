using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationusingWhileloopbyconcatination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input;

            //Read data from user
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());
            int i = 1; 

            //Logic and Output
            while(i<=10)
            {
                //Console.WriteLine(input + "x" + i + "=" + input * i);
                Console.WriteLine("{0}x{1}={2}",input,i,input*i);
                i++;
            }
        }
    }
}

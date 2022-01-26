using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicationtable2ndway
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


            //Logic and Output
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("{0} x {1} = {2}",input,i,input*i);
            }
        }
    }
}

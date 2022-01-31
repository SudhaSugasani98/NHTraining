using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellousingWhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input, i = 1;

            //Read data from user
            Console.WriteLine("Enter any Number");
            input=Convert.ToInt32(Console.ReadLine());
            
            //Logic and Output
            while(i<=input)
            {
                Console.WriteLine("Hello");
                i++;
            }

        }
    }
}

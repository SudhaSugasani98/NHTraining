using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input;
            int a = 0, b = 1;
            Console.WriteLine("Enter a number");
            input=Convert.ToInt32(Console.ReadLine());

            //Logic and printing output

            Console.WriteLine("Fibbonaci series:");
            for(int i = 0; i < input; i++)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();

        }
    }
}

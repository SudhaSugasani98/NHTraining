using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and reading data from user
            int input;
            Console.WriteLine("Enter a number");
            input =Convert.ToInt32(Console.ReadLine());


            //Printing Output
            if(isPrimenumber(input))
                    Console.WriteLine("{0} is a primenumber",input);
            else
                Console.WriteLine("{0} is not a primenumber", input);
             Console.ReadLine();

        }

        //Logic and returning Output
        public static Boolean isPrimenumber(int input)
        {
            int i;
            for( i=2;i<input;i++)
            {
                if (input % i == 0)
                    break;
            }
            if(i==input)
                    return true;
            else
                return false;
        }
    }
}

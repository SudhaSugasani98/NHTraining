using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrongnumberusingfunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Variable declaration and read data from user
 
             int input;
            
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());

            
            //Printing Output

            if (isArmstrongnumber(input))
                Console.WriteLine("{0} is a Armstrong number", input);
            else
                Console.WriteLine("{0} is  not a Armstrong number", input);
            Console.ReadLine();
        }
        //Logic

        public static Boolean isArmstrongnumber(int input)
        {
            int m, rem;
            int result = 0;
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem * rem * rem;
            }
            if (result == input)
               return true;
            else
                return false;
           
        

        }
    }
}

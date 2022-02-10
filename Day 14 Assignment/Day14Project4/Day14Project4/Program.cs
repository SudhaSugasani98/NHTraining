using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project4
{
    /*****************************************************************
     * Author:Sudha Kumari Sugasani
     * Purposse:Program to check the number is prime or not using break
     * ***************************************************************/
    class Prime
    {
       /// <summary>
       /// This method will check the given number is prime or not
       /// </summary>
        public void IsPrime()
        { 
             int n , i;
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=2;i<n;i++)
            {
               if(n%i==0)
               break;
            }
             if(i==n)
            Console.WriteLine($"{n} is a Prime Number");
             else
            Console.WriteLine($"{n} is not a Prime Number");

        }
       
     }
    internal class Program
    {
        static void Main(string[] args)
        {
           Prime p1=new Prime();
            p1.IsPrime();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project1
{
    /*********************************************************************
     * Author:Sudha Sugasani
     * Purpose:Program to find factorial of a number,factors of a number,
     *         to check given number is prime or not
     * *******************************************************************/

     class Mathsoperations 
     {
        private int input;
        public void Readinput()
        {
            Console.WriteLine("Enter number");
            input=Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            int fact = 1;
            for(int i=1;i<=input;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public void Printfactors()
        {
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine($"Factors of {input} is {i}");
                }
            }
        }
        public bool Isprime()
        {
            int count = 0;
            for (int i = 1;i <input;i++)
            {
                if(input % i == 0)
                {
                    count++;
                }
            }
            if(count==1)
                return true;
            else
                return false;
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathsoperations obj=new Mathsoperations();
            obj.Readinput();
            Console.WriteLine($"Factorial of given number is {obj.Factorial()}");
            obj.Printfactors();
            if (obj.Isprime())
                Console.WriteLine("Input is a prime number ");
            else
                Console.WriteLine("Input is not a prime number");
            Console.ReadLine();
        }
    }
}

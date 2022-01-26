using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsofgivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input;

            //Read input from user
            Console.WriteLine("Enter any number");
            input=Convert.ToInt32(Console.ReadLine());


            //Logic and Output
            for(int i = 1; i < input;i++)
            {
                if(input%i==0)
                {
                    Console.WriteLine(i);  
                }
            }
        }
    }
}

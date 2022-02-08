
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project2
{
   

    internal class Program
    {
        /*******************************************************
         * Author:Sudha Sugasani
         * Purpose:Program to show the use of finally block
         * *****************************************************/

        static void Main(String[] args)
        {
             try
             {
                 int a = 100;
                 int b = 5;
                 int c = a / b;
                 Console.WriteLine($"Division of two numbers is {c}");
             }
             catch(Exception)
             {

             }
             finally
             {
                 Console.WriteLine("\n\n\n\n\n Designed by Sudha Sugasani");
                 Console.ReadLine();
             }





        }
        
    }
}

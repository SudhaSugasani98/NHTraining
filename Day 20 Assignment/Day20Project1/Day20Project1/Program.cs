using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project1
{
    /******************************************
     * Author:Sudha Sugasani
     * Purpose:Example program for delegates
     * ****************************************/


    /// <summary>
    /// By creating this method we will use delegates
    /// </summary>
    /// <param name="a">int</param>
    /// <param name="b">int</param>
    public delegate void Mycaller(int a, int b);
    class Delegates1
    {
        /// <summary>
        /// This method will caluculate the Division of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
       public static void Div(int a,int b)
        {
            Console.WriteLine($"The division of two numbers is {a/b}");
        }

        /// <summary>
        /// This method will caluculate the ModularDivision of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        
        public static void ModuloDiv(int a,int b)
        {
            Console.WriteLine($"The Modular Division of two numbers is {a%b}");
        }
        /// <summary>
        /// This method will caluculate the Product of two numbers
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        
        public static void Mul(int a,int b)
        {
            Console.WriteLine($"The Product of two numbers is {a*b}");
        }

    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Mycaller mc = new Mycaller(Delegates1.Div);
            mc += Delegates1.ModuloDiv;
            mc += Delegates1.Mul;
           
            //25,13
            mc(25, 13);

            //19,15
            mc(19, 15);

            Console.ReadLine();
        }
    }
}

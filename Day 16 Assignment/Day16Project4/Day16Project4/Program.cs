using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project4
{
    /***************************************************
     *Author:Sudha Kumari Sugasani
     *Purpose:Program to print multiplication table of 
     *        a number in object oriented way.
     * **************************************************/
    class Table
    {
        public int input;
        /// <summary>
        /// This method is used to read data from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method is used to print Multiplication table
        /// </summary>
        public  void GetMultiplicationTable()
        {
            Console.WriteLine($"Multiplication table of {input} is");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(input+"*"+i+"="+(input*i));
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table();
            t1.ReadData();
            t1.GetMultiplicationTable();
            Console.ReadLine();
        }
    }
}

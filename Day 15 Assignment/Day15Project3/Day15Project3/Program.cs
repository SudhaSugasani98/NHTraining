using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project3
{
    /**************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program for Files using Streamwriter method
     **************************************************************/
    class Files3
    {
        /// <summary>
        /// This method is used to append the text in the file
        /// </summary>
        public void Streamwriter1()
        {
            StreamWriter sw = new StreamWriter("C:\\NH\\Files Using C#\\Hello.txt", true);
            sw.WriteLine("\nI'm overriding this file");
            sw.WriteLine("Thank you");
            sw.Close();
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Files3 obj=new Files3();
            obj.Streamwriter1();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

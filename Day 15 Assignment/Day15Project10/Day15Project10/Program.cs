using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project10
{
   

        /**************************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Example program for Files using Copy method
         **************************************************************/
        class Files10
        {
            /// <summary>
            /// This method is used to Copy the files from one folder to another
            /// </summary>
            public void Copy1()
            {
                File.Copy("C:\\NH\\Files Using C#\\Hello.txt", "C:\\NH\\Copied files\\Hello.txt");
                Console.WriteLine("File Copied Successfully");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Files10 obj = new Files10();
                obj.Copy1();
                Console.ReadLine();
            }
        }
    }



 
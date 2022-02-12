using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project6
{
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         FileInfo.Create method
         ************************************************/

        class File6
        {
            /// <summary>
            /// This method is used to create a file and writes text in that
            /// </summary>
            public void CreateFile()
            {
                //To create a file
                FileInfo f1 = new FileInfo("C:\\NH\\Files Using C#\\Hello.txt");
               StreamWriter str = f1.CreateText();
                str.WriteLine("Hi");
                str.WriteLine("Hello");
                str.Close();
                Console.WriteLine("File Created");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File6 f6 = new File6();
                f6.CreateFile();
                Console.ReadLine();
            }
        }
    }
   
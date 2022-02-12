using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project9
{
   
        /**************************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Example program for Files using StreamReader method
         **************************************************************/
        class Files9
        {
            /// <summary>
            /// This method is used to append the text in the file
            /// </summary>
            public void StreamReader1()
            {
                StreamReader sr = new StreamReader("C:\\NH\\Files Using C#\\Hello.txt");
                String data = sr.ReadLine();
                while(data != null)
                {
                  Console.WriteLine(data);
                   data = sr.ReadLine();

                }

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Files9 obj = new Files9();
                obj.StreamReader1();
                Console.ReadLine();
            }
        }
    }


   
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project1
{
    
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         File.Create method
         ************************************************/

        class File1
        {
            /// <summary>
            /// This method is used to create a file
            /// </summary>
            public void CreateFile()
            {
                //To create a file
                File.Create("C:\\NH\\Files Using C#\\Hello.txt");
                Console.WriteLine("File Created");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File1 f1 = new File1();
                f1.CreateFile();
                Console.ReadLine();
            }
        }
    }

 
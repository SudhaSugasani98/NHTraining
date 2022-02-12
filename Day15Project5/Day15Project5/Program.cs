using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project5
{
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         FileInfo method
         ************************************************/

        class File5
        {
            /// <summary>
            /// This method is used to create a file
            /// </summary>
            public void CreateFile()
            {
                //To create a file
                FileInfo f1=new FileInfo("C:\\NH\\Files Using C#\\Hello.txt");
                File.Create("C:\\NH\\Files Using C#\\Hello.txt");
                Console.WriteLine("File Created");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File5 f5 = new File5();
                f5.CreateFile();
                Console.ReadLine();
            }
        }
    }
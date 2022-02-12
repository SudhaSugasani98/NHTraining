using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project8
{
   
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         File.GetCreationTime method
         ************************************************/

        class File8
        {
            /// <summary>
            /// This method is used to see the creation time of the file
            /// </summary>
            public void Time()
            {
                //To see creation time
                Console.WriteLine($"Creation time of the file is {File.GetCreationTime("C:\\NH\\Files Using C#\\Hello.txt")}");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File8 f8 = new File8();
                f8.Time();
                Console.ReadLine();
            }
        }
    }
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project7
{
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         File.GetLastWriteTime method
         ************************************************/

        class File7
        {
            /// <summary>
            /// This method is used to see the last modified time of the file
            /// </summary>
            public void Time()
            {
                //To see last modified time
                Console.WriteLine($"Last Modified time is {File.GetLastWriteTime("C:\\NH\\Files Using C#\\Hello.txt")}");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File7 f7 = new File7();
                f7.Time();
                Console.ReadLine();
            }
        }
    }

   
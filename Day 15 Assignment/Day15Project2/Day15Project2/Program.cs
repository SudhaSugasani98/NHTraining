using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project2
{
   

        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         File.WriteAllText method
         ************************************************/

        class File2
        {
            /// <summary>
            /// This method is used to Write mesage in the file
            /// </summary>
            public void WriteMessage()
            {
                //To wrie message file
                File.WriteAllText("C:\\NH\\Files Using C#\\Hello.txt","Hi\nI'm learning C#");
                Console.WriteLine("Message added sussfully");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File2 f2 = new File2();
                f2.WriteMessage();
                Console.ReadLine();
            }
        }
    }


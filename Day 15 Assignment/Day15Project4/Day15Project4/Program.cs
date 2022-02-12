using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project4
{
    
        /*************************************************
         * Author:Sudha Kumari Sugasani
         * Puropse:Example Program for File class using 
         *         File.Delete method
         ************************************************/

        class File4
        {
            /// <summary>
            /// This method is used to delete a file
            /// </summary>
            public void Delete()
            {
                //To delete file
                File.Delete("C:\\NH\\Files Using C#\\Hello.txt");
                Console.WriteLine("File deleted");

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                File4 f4 = new File4();
                f4.Delete();
                Console.ReadLine();
            }
        }
    }

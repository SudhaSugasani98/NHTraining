using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10project5
{

        /***************************************************************************
         * Author:Sudha Sugasani
         * Purpose:Example code for Method Overriding using virtual,override keyword       
         ****************************************************************************/

        class EnglishMessage
        {
            /// <summary>
            /// This method will print Hi message
            /// </summary>

            public void PrintHi()
            {
                Console.WriteLine("Hi");
            }

            /// <summary>
            /// This method will print Hello Message
            /// </summary>


            public void PrintHello()
            {
                Console.WriteLine("Hello");
            }


            /// <summary>
            /// This method will print Good Morning message
            /// </summary>
            public virtual void PrintGM()
            {
                Console.WriteLine("Good Morning");
            }
        }
        class TeluguMessage : EnglishMessage
        {
            /// <summary>
            /// This method will print Subhodhayam message
            /// </summary>
            public override void PrintGM()
            {
                Console.WriteLine("Subhodhayam");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                TeluguMessage m1 = new TeluguMessage();
                m1.PrintHi();
                m1.PrintHello();
                m1.PrintGM();

                Console.ReadLine();

            }
        }


    }
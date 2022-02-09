using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project8
{
        /******************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Declaration and printing of a jagged array
         *         using character array
         * ****************************************************/
        internal class Program
        {
            static void Main(string[] args)
            {
                //Declaration and intialisation of jagged character array
                char[][] data = new char[5][];
                data[0] = new char[] { 's','u','d','h','a' };
                data[1] = new char[] { 's', 'u', 'd', 'h', 'a','s' };
                data[2] = new char[] { 's', 'u', 'd', 'h', 'a','s','u' };
                data[3] = new char[] { 's', 'u', 'd', 'h', 'a','s','u','g' };
                data[4] = new char[] { 's', 'u', 'd', 'h', 'a','s','u','g','a','s','a','n','i' };

            //Printing of jagged character array values
            for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < data[i].Length; j++)
                    {
                        Console.Write(data[i][j] + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();

            }
        }
    }
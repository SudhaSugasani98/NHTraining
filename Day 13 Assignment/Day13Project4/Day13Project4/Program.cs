using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


            /****************************************************************
             * Author:Sudha Kumari Sugasani
             * Purpose: Declaration of 2 dimensional array  of size(2x2),
             *          read values from user and print the array values.
             * ***************************************************************/
            internal class Program
            {
                static void Main(string[] args)
                {

                    int[,] data = new int[2, 2];
                    //Read data from user

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                         Console.WriteLine($"Enter array value at ({i},{j})");
                           data[i,j]=Convert.ToInt32(Console.ReadLine());
                        }

                    }
                    //Printing array values
                     for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write(data[i,j]+" ");
                        
                        }
                    Console.WriteLine();

                    }
            
                    Console.ReadLine();
                }
            }
  }

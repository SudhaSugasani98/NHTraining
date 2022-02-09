using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   
        /****************************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose: Declaration of 2 dimensional array  of size(3x2),
         *          print trace of the array.
         * ***************************************************************/
        internal class Program
        {
            static void Main(string[] args)
            {
                int sum = 0;
                int[,] data = new int[,] { { 5, 6 ,15}, { 48, 18 ,13}, { 56, 78,22 } };

                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if(i==j)
                        {
                            sum=sum+data[i,j];
                        }
                        
                        
                    }
                    
                }
                Console.WriteLine($"The trace of given array is {sum}");
                Console.ReadLine();
            }
        }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project7
{
    /******************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Declaration and printing of a jagged array
     * ****************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration and intialisation of jagged array
            int [][] values=new int[10][];
            values[0] = new int[] {15,1,2};
            values[1] = new int[] { 25 ,3,2,1};
            values[2] = new int[] { 33 ,55,66,77,1234};
            values[3] = new int[] { 5 ,7689,789098,2231};
            values[4] = new int[] { 10,67,89,22 ,12,11};
            values[5] = new int[] { 18 ,15,14,13,5};
            values[6] = new int[] { 46 ,55,45,35};
            values[7] = new int[] { 7,789,2223};
            values[8] = new int[] { 2,5,7,9};
            values[9] = new int[] { 11 };

            //Printing of jagged array values
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0;j<values[i].Length;j++)
                {
                    Console.Write(values[i][j]+" ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}

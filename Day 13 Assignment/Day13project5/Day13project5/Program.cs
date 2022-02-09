using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project5
{
    /*********************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Sum of two 2 dimensional arrays of size(2x2)
     * ******************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int [,] data1=new int[2,2];
            //Reading array1 values from user
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine($"Enter value at data1 ({i},{j})");
                    data1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] data2= new int[2, 2];
            //Reading array2 values from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter value at data2 ({i},{j})");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Printing addition of two arrays
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data1[i,j]+data2[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

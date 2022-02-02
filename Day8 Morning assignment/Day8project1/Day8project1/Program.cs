using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project1
{
    /*******************************************************************************************************
     *Author:Sudha Sugasani
     *Purpose:Program to find even numbers by list using for loop,foreach loop,lambda expression,Linq query
     ********************************************************************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 54, 25, 87, 66, 4, 987, 32, 78 };

            //Even numbers using for loop
            for(int i=0;i<data.Count;i++)
            {
                if(data[i]%2==0)
                    Console.WriteLine($"Even numbers using for loop={data[i]}");
            }

            //Even numbers using foreach loop
            foreach(var d in data)
            {
                if (d%2==0)
                    Console.WriteLine($"Even numbers using foreach loop={d}");
            }

            //Even numbers using lambda expression
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine($"Even numbers using lambda expression={d}"));

            //Even numbers using Linq query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d=>Console.WriteLine($"Even numbers using Linq query={d}"));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printvaluesusingforeachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration

            int[] data = new int[4];
            

            //Read data from user
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number:");
                data[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Logic and output
            foreach(int d in data)
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();
        }
    }
}

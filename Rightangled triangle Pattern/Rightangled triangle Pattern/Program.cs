using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightangled_triangle_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration

            int input,i,j;
            Console.WriteLine("No.of rows to be print");
            input=Convert.ToInt32(Console.ReadLine());

            //Logic and output

            for(i=1;i<=input;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

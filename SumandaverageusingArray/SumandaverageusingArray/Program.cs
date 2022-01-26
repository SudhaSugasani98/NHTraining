using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumandaverageusingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration

            int[] data = new int[5];
            int Sum = 0;
            int Average;

            //Read data from user
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number:");
                data[i] = Convert.ToInt32(Console.ReadLine());
                
            }


            //Logic
            for(int i=0;i<data.Length;i++)
            {
                Sum= Sum + data[i];
            }
            Average = Sum/5;
            //Print Output

            Console.WriteLine("Sum=" + Sum);
            Console.WriteLine("Average"+Average);
            Console.ReadLine();
            
        }
    }
}

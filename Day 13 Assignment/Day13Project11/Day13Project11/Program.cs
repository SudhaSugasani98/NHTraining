using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project11
{
   
        /**********************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Example program for Queue
         * ********************************************/
        internal class Program
        {
            static void Main(string[] args)
            {
                Queue<int> data = new Queue<int>();
                data.Enqueue(10);
                data.Enqueue(15);
                data.Enqueue(30);
                Console.WriteLine($"Count before Dequeue is {data.Count}");
                Console.WriteLine($"Dequeue value is {data.Dequeue()}");
                Console.WriteLine($"Count after Dequeue is {data.Count}");
                Console.WriteLine($"Count before Peek is {data.Count}");
                Console.WriteLine($"Peek value is {data.Peek()}");
                Console.WriteLine($"Count after Peek is {data.Count}");
                Console.ReadLine();
            }
        }
    }

 

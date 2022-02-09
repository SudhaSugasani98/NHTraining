using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project10
{
    /**********************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program for stack
     * ********************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(10);
            data.Push(20);
            data.Push(30);
            Console.WriteLine($"Count before pop is {data.Count}");
            Console.WriteLine($"Pop value is {data.Pop()}");
            Console.WriteLine($"Count after pop is {data.Count}");
            Console.WriteLine($"Count before peek is {data.Count}");
            Console.WriteLine($"Peek value is {data.Peek()}");
            Console.WriteLine($"Count after peek is {data.Count}");
            Console.ReadLine();
        }
    }
}

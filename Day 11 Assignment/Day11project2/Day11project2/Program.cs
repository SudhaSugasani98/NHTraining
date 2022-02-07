using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project2
{
    internal class Program
    {
        /******************************************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Example program for properties
         * ****************************************************************************/
        class Circle
        {
            public int Radius { get; set; }
            public int Area
            {
                get
                {
                    return 22 * Radius * Radius / 7;
                }
            }
            public int Perimeter
            {
                get
                {
                    return 2 * 22 * Radius / 7;
                }
            }

        }
            static void Main(string[] args)
            {
                Circle c1 = new Circle();
            c1.Radius = 5;
            Console.WriteLine($"Radius of Circle is {c1.Radius}");
            Console.WriteLine($"Area of Circle is {c1.Area}");
            Console.WriteLine($"perimeter of Circle is {c1.Perimeter}");
            Console.ReadLine();
            }
        }
    }


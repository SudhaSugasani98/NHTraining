using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project1
{
        /******************************************************************************
         * Authhor:Sudha Kumari Sugasani
         * Purpose:Creating an Interface name with IShape which imclude the classes 
         *          Circle,Square,Traingle,Rectangle
         * ****************************************************************************/
        interface IShape
        {
            int CaluculatePerimeter();
            int CaluculateArea();

        }
        class Circle : IShape
        {

            private int radius;
            /// <summary>
            /// This method will read the input from the user.
            /// </summary>
            public void ReadRadius()
            {
                Console.WriteLine("Enter radius");
                radius = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// This method will caluculate the Perimeter of the Circle
            /// </summary>
            /// <returns>Perimeter of the Circle</returns>
            public int CaluculatePerimeter()
            {
                return 2 * 22 * radius / 7;
            }
            /// <summary>
            /// This method will caluculate the Area of the Circle 
            /// </summary>
            /// <returns>Area of the Circle</returns>
            public int CaluculateArea()
            {
                return 22 * radius * radius / 7;
            }

        }
        class Square : IShape
        {

            private int side;
            /// <summary>
            /// This method will read the input from the user.
            /// </summary>
            public void ReadSide()
            {
                Console.WriteLine("Enter side");
                side = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// This method will caluculate the Perimeter of the Square
            /// </summary>
            /// <returns>Perimeter of the Square</returns>
            public int CaluculatePerimeter()
            {
                return 4 * side;
            }
            /// <summary>
            /// This method will caluculate the Area of the Square 
            /// </summary>
            /// <returns>Area of the Square</returns>
            public int CaluculateArea()
            {
                return side * side;
            }

        }
        class Rectangle : IShape
        {

            private int length;
            public int breadth;
            /// <summary>
            /// This method will read the input from the user.
            /// </summary>
            public void ReadLengthandBreadth()
            {
                Console.WriteLine("Enter Length");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Breadth");
                breadth = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// This method will caluculate the Perimeter of the Rectangle
            /// </summary>
            /// <returns>Perimeter of the Rectangle</returns>
            public int CaluculatePerimeter()
            {

                return (length + breadth) * 2;
            }
            /// <summary>
            /// This method will caluculate the Area of the Rectangle 
            /// </summary>
            /// <returns>Area of the Circle</returns>
            public int CaluculateArea()
            {
                return (length * breadth);
            }

        }
        class Triangle : IShape
        {

            private int side1;
            private int side2;
            private int side3;
            public int semiparameter;


            /// <summary>
            /// This method will read the input from the user.
            /// </summary>
            public void ReadSides()
            {
                Console.WriteLine("Enter Side1");
                side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Side2");
                side2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Side3");
                side3 = Convert.ToInt32(Console.ReadLine());
                semiparameter = (side1 + side2 + side3) / 2;


            }


            /// <summary>
            /// This method will caluculate the Perimeter of the Triangle
            /// </summary>
            /// <returns>Perimeter of the Traingle</returns>
            public int CaluculatePerimeter()
            {
                int perimeter;
                perimeter = (side1 + side2 + side3);
                return perimeter;
            }
            /// <summary>
            /// This method will caluculate the Area of the Triangle
            /// </summary>
            /// <returns>Area of the Traingle</returns>
            public int CaluculateArea()
            {
                int Area;
                int s1, s2, s3;
                s1 = (semiparameter - side1);
                s2 = (semiparameter - side2);
                s3 = (semiparameter - side3);
                Area = (int)Math.Sqrt((semiparameter) * (s1 * s2 * s3));
                //Area = (int)Math.Sqrt((semiparameter) * ((semiparameter - side1) * (semiparameter - side2) * (semiparameter - side3)));
                return Area;
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c1 = new Circle();
                c1.ReadRadius();
                Console.WriteLine($"Area of Circle is {c1.CaluculateArea()}");
                Console.WriteLine($"Perimeter of Circle is {c1.CaluculatePerimeter()}");
                Square s1 = new Square();
                s1.ReadSide();
                Console.WriteLine($"Area of Square is {s1.CaluculateArea()}");
                Console.WriteLine($"Perimeter of Square is {s1.CaluculatePerimeter()}");
                Rectangle r1 = new Rectangle();
                r1.ReadLengthandBreadth();
                Console.WriteLine($"Area of Rectangle is {r1.CaluculateArea()}");
                Console.WriteLine($"Perimeter of Rectangle is {r1.CaluculatePerimeter()}");
                Triangle t1 = new Triangle();
                t1.ReadSides();
                Console.WriteLine($"Area of Triangle is {t1.CaluculateArea()}");
                Console.WriteLine($"Perimeter of Triangle is {t1.CaluculatePerimeter()}");
                Console.ReadLine();
            }
        }
    }

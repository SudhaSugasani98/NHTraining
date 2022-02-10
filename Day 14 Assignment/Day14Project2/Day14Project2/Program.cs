using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2
{
    /*************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program for normal properties
     * ***********************************************/
    class AverageSpeed
    {
        private int distance;
        private int time;
        private int speed;
        public int Distance
        {
            set
            {
                distance = value;
            }
        }
        public int Time
        {
            set { time = value; }
        }
        public int Speed
        {
            get
            {
                speed = distance / time;
                return speed;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageSpeed avg = new AverageSpeed();
            avg.Distance = 10;
            avg.Time = 5;
            Console.WriteLine($"Speed is {avg.Speed}");
            Console.ReadLine();
        }
    }
}

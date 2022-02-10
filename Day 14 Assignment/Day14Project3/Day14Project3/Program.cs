using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project3
{
   
        /*********************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Example program for auto-implemented properties
         * *******************************************************/
        class AverageVelocity
        {
            
            public int Displacement
            {
            get
            {
                return 50;
            }
            }
            public int Time
            {
                get{ return 20; }
            }
            public int Velocity
            {
            
                get
                {
                   
                    return Displacement/Time;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                AverageVelocity vel=new AverageVelocity();
                Console.WriteLine($"Displacement is { vel.Displacement}");
                Console.WriteLine($"Time is {vel.Time}");
                Console.WriteLine($"Velocity is {vel.Velocity}");
                Console.ReadLine();
            }
        }
    }

  
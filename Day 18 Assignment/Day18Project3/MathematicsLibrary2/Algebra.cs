﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary2
{
        /*************************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Creating MathemematicsLibrary to reuse this in other
         *         Libraries or applications.
         * ***********************************************************/
        public class Algebra
        {
           
            /// <summary>
            /// This method is used to get factorial of number
            /// </summary>
            /// <param name="n">int</param>
            /// <returns>Factorial value(int)</returns>
            public static int Factorial(int n)
            {
                
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            

            }
            /// <summary>
            /// This method is used to check given number is palindrome or not
            /// </summary>
            /// <param name="input">int</param>
            public static bool isPalindromeorNot(int input)
            {
                int m, rem;
                int rev = 0;
                m = input;
               while(m>0)
               {
                    rem = m % 10;
                    m = m / 10;
                    rev = rev * 10 + rem;
               }
                if(input==rev)
                {
                    return true;
                 
                }
                else
                {
                   return false;
                
                }
            
               
            }
        }
    }




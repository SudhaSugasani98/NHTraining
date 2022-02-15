using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaLibrary
{
   /*********************************************************
    * Author:Sudha Kumari Sugasani
    * Purpose:Example to understand about Access Modifiers
    * *******************************************************/

    public class MyBaseClass
    {
        public int a ;
        private int b ;
        protected int c ;
        internal int d;
        protected internal int e ;
        /// <summary>
        /// Accessing variables in same class
        /// </summary>
        public void MyBaseClassMetod()
        {
            a = 5;
            b = 19;
            c = 7;
            d = 5;
            e = 15;
        }
    }
    public class MyDerivedClass:MyBaseClass
    {
        /// <summary>
        /// Accessing variabes in derived class in same library
        /// </summary>
       public void MyDerivedClassmethod()
        {
            a = 6;
            b = 9;
            c = 15;
            d = 12;
            e = 10;
        }
    }
    public class MyOtherClass
    {
        /// <summary>
        /// Accessing variables in other class in same library
        /// </summary>
        public void MyOtherClassMethod()
        {
            MyBaseClass m1 = new MyBaseClass();
            m1.a = 10;
            m1.b = 20;
            m1.c = 7;
            m1.d = 15;
            m1.e = 22;
        }
        
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudhaLibrary;

namespace PublicLibrary
{
    public class MyDerivedClass:MyBaseClass
    {
        /// <summary>
        /// Implementing Base class variables into Derivedclass in other library
        /// </summary>
        public void MyPublicBaseClassMethod()
        {
            a = 5;
            b = 10;
            c = 15;
            d= 20;
            e = 25;
        }
    }
    public class MyPublicOtherClass
    {
        /// <summary>
        /// Accessing base class variables in other class in other library
        /// </summary>
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            mb.a = 6;
            mb.b = 5;
            mb.c = 78;
            mb.d = 55;
            mb.e = 15;
        }
    }
}

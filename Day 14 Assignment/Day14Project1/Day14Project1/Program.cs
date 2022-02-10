using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1
{
    /***********************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example for sealed class
     **********************************/
    sealed class Police
    {
        public static int Helpline = 100;
        public string GetSecret()
        {
            return "Secret";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Police p = new Police();
            Console.WriteLine(p.GetSecret());
            Console.WriteLine(Police.Helpline);
            Console.ReadLine();
        }
    }
}

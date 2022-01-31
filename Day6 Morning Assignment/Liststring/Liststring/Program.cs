using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liststring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Sudha");
            data.Add("Rama");
            data.Add("Lehana");
            data.Add("Neeraja");
            //Print values using for
            for(int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }
           
            //Print values using foreach loop
            foreach(var d in data)
            { 
                Console.WriteLine(d);   
            }
            
            //Print values using lambda expression
            data.ForEach(p =>Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}

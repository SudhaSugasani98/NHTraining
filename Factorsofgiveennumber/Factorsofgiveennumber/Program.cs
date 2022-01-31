using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorsofgiveennumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                    
                }
            }
            Console.ReadLine();
        }
    }
}

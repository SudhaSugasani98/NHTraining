using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaSugasaniLibrary
{
    public  class Mathematics
    {
        
        public static int Factorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudhaSugasaniLibrary
{
    public class Physics
    {
        /// <summary>
        /// This method will return FinalVelocity
        /// </summary>
        /// <param name="u">int</param>
        /// <param name="t">int</param>
        /// <param name="a">int</param>
        /// <returns>Final Velocity(int)</returns>
        public static int FinalVelocity(int u,int t,int a)
        {
            return u + a * t;
        }
    }
}

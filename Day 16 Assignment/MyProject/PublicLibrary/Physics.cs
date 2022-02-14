using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicLibrary
{
    /****************************************************************
     * Author:Sudha Sugasani
     * Purpose:Creating PublicLibrary and adding class,methods in it
     * **************************************************************/
    public class Physics
    {
        /// <summary>
        /// This method is used to find speed
        /// </summary>
        /// <param name="distance">int</param>
        /// <param name="time">int</param>
        /// <returns>Speed(int)</returns>
        public static int Speed(int distance,int time)
        {
            return distance / time; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project1
{

    /***************************************************************************
     * Author:Sudha Kumari Sugasani
     * Puropse:Program to handle three exceptions and adding super exception
     *         at last.
     * ************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int fn, sn, division;
                Console.WriteLine("Enter first number");
                fn=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                sn=Convert.ToInt32(Console.ReadLine());
                division = fn / sn;
                Console.WriteLine($"The division of two numbers is {division}");

            }
            catch(OverflowException)
            {
                Console.WriteLine("Enter only numbers between 0 and 9000000000");
                Console.ReadLine();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide with zero");
                Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter only numbers");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Some error occured,Please contact admin");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\nDesigned by Sudha Sugasani");
                Console.ReadLine();
            }
        }
    }
}

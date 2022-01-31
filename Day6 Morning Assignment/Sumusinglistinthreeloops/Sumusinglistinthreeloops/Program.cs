using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumusinglistinthreeloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0, sum2 = 0, sum3 = 0;

            //Read 5 numbers from user
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Enter any value");
                temp=Convert.ToInt32(Console.ReadLine());
                data.Add(temp); 
            }
            //Print sum using forloop
            for (int i = 0; i < data.Count; i++)
            {
                sum1 = sum1 + data[i];
                
            }
            Console.WriteLine("Sum of values using forloop is {0}",sum1);

            //Print sum using foreach loop
            foreach (var d in data)
            {
                sum2= sum2 + d;
                
            }
               Console.WriteLine("Sum of values using foreachloop is {0}",sum2);

            //Print sum using lambda expression
            data.ForEach(p =>sum3=sum3+p );
            Console.WriteLine("Sum of values using lambda expression is {0}",sum3);
            Console.ReadLine();
        }
    }
}

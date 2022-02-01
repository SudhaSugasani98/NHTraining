using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project4
{
    class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /************************************************************************************************
             * Author:Sudha Sugasani
             * Purpose:Employee class using Array
             ************************************************************************************************/

            Employee[] emp = new Employee[]
            {
                new Employee() { Id = 1, Name = "Sudha", Salary = 5000 },

                new Employee() { Id = 2, Name = "Harika", Salary = 7000 },

                new Employee() { Id = 3, Name = "Lehana", Salary = 3000 },

                new Employee() { Id = 4, Name = "Susmitha", Salary = 4000 }
            };
            //Print the values using for loop

            for(int i=0; i<emp.Length; i++)

            {
                Console.WriteLine($"Id={emp[i].Id},Name={emp[i].Name},Salary={emp[i].Salary}");
            }
            

            //Print the values using foreah loop

            foreach(var e in emp)
            {
                Console.WriteLine($"Id={e.Id},Name={e.Name},Salary={e.Salary}");
            }

            //Print values using Lambda Expression

            emp.ToList().ForEach(e => Console.WriteLine($"Id={e.Id},Name={e.Name},Salary={e.Salary}"));
           
            Console.ReadLine();

           }

        }
    }


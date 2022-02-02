using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project2
{
  
        /*********************************************************************************************************
         *Author:Sudha Sugasani
         *Purpose:Create Employee class with three variables,create list of employees print values using for loop,
         *         foreach loop,lambda expression,linq query
         **********************************************************************************************************/


    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Employee> emp = new List<Employee>() 
                { 
                    new Employee(){id=1,name="sudha",salary=5000 },
                    new Employee(){id=2,name="lehana",salary=6000 },
                    new Employee(){id=3,name="neeraja",salary=8000 },
                    new Employee(){id=4,name="puja",salary=4500 },
                    new Employee(){id=5,name="gayathri",salary=3000 }
                };

                //Employees names using for loop
                for (int i = 0; i < emp.Count; i++)
                {
                    if (emp[i].salary>5000)
                        Console.WriteLine($"Employees whose salary is >5000 using for loop={emp[i].name}");
                }

                //Employees names using foreach loop
                foreach (var e in emp)
                {
                    if (e.salary>5000)
                        Console.WriteLine($"Employees whose salary is >5000 using foreach loop={e.name}");
                }

                //Employees names using lambda expression
                emp.Where(e=> e.salary>5000).ToList().ForEach(e => Console.WriteLine($"Employees names whose salary is >5000 using lambda expression={e.name}"));

                //Employees names using Linq query
                var result = from e in emp
                             where e.salary>5000
                             select e.name;
                result.ToList().ForEach(e => Console.WriteLine($"Employees names whose salary is >5000 using Linq query={e}"));

                Console.ReadLine();
            }
        }
    }




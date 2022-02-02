using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project4
{
   


        /*********************************************************************************************************
         *Author:Sudha Sugasani
         *Purpose:Create Department class whose empcount is >50 print values using for loop,
         *         foreach loop,lambda expression,linq query
         **********************************************************************************************************/


        class Department
        {
            public int id;
            public string name;
            public int empcount;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
            List<Department> dep = new List<Department>()
                {
                    new Department() {id=1,name="Development",empcount=60 },
                    new Department() { id = 2, name = "Testing", empcount = 55 },
                    new Department() { id = 3, name = "HR", empcount = 5 },
                    new Department() { id = 4, name = "UI", empcount = 80},
                    new Department() { id = 5, name = "BA", empcount = 20 },

                };

               //Department id,names using for loop
                for (int i = 0; i <dep.Count; i++)
                {
                    if (dep[i].empcount > 50)
                        Console.WriteLine($"Departments whose empcount is >50 using for loop={dep[i].id},{dep[i].name}");
                }

                //Department id,name using foreach loop
                foreach (var d in dep)
                {
                    if (d.empcount > 50)
                        Console.WriteLine($"Departments whose empcount is >50 using foreach loop={d.id},{d.name}");
                }

                //Department  id,names using lambda expression
                dep.Where(d => d.empcount > 50).ToList().ForEach(d => Console.WriteLine($"Departments whose empcount is >50 using lambda expression={d.id},{d.name}"));

                //Department id,names using Linq query
                var result = from d in dep
                             where d.empcount > 50
                             select d.id + "," + d.name;
                result.ToList().ForEach(d => Console.WriteLine($"Departments whose empcount is >50 using Linq query={d}"));

                Console.ReadLine();
            }
        }
    }

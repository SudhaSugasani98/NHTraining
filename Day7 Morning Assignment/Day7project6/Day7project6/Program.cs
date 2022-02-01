using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project6
{
    internal class Program
    {
       
            class Customer
            {
                public int Id;
                public string Name;
                public string location;
            }

            static void Main(string[] args)
            {
                /************************************************************************************************
                 * Author:Sudha Sugasani
                 * Purpose:Customer class using Array whose Location is Hyderabad
                 ************************************************************************************************/

                Customer[] cus = new Customer[]
                {
                new Customer() { Id = 1, Name = "Sudha", location = "Hyderabad" },

                new Customer() { Id = 2, Name = "Harika", location = "Banglore"},

                new Customer() { Id = 3, Name = "Lehana", location = "Vijayawada" },

                new Customer() { Id = 4, Name = "Susmitha", location = "Hyderabad" }
                };
                //Print the values using for loop

                for (int i = 0; i < cus.Length; i++)

                {
                    if (cus[i].location is "Hyderabad")
                        Console.WriteLine($"Id={cus[i].Id},Name={cus[i].Name},Location={cus[i].location}");
                }


                //Print the values using foreah loop

                foreach (var e in cus)
                {
                    if (e.location is "Hyderabad")
                        Console.WriteLine($"Id={e.Id},Name={e.Name},Location={e.location}");
                }

                //Print values using Lambda Expression

                cus.ToList().Where(e => e.location is "Hyderabad").ToList().ForEach(e => Console.WriteLine($"Id={e.Id},Name={e.Name},Location={e.location}"));

                Console.ReadLine();

            }

        }
    }


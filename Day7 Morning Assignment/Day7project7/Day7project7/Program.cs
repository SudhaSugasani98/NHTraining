using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project7
{
    internal class Program
     {

            class Product
            {
                public int Id;
                public string Name;
                public int price;
            }

            static void Main(string[] args)
            {
                /************************************************************************************************
                 * Author:Sudha Sugasani
                 * Purpose:Product class using Array whose Price <=30000
                 ************************************************************************************************/

               Product[] p1 = new Product[]
                {
                new Product() { Id = 1, Name = "Mobile", price=15000 },

                new Product() { Id = 2, Name = "Powerbank", price=3000},

                new Product() { Id = 3, Name = "Washing Machine", price=50000 },

                new Product() { Id = 4, Name = "TV", price=75000 }
                };
                //Print the values using for loop

                for (int i = 0; i < p1.Length; i++)

                {
                    if (p1[i].price<=30000)
                        Console.WriteLine($"Id={p1[i].Id},Name={p1[i].Name},Price={p1[i].price}");
                }


                //Print the values using foreah loop

                foreach (var e in p1)
                {
                    if (e.price <=30000)
                        Console.WriteLine($"Id={e.Id},Name={e.Name},price={e.price}");
                }

                //Print values using Lambda Expression

                p1.ToList().Where(e => e.price <=30000).ToList().ForEach(e => Console.WriteLine($"Id={e.Id},Name={e.Name},Price={e.price}"));

                Console.ReadLine();

            }

        }
    }




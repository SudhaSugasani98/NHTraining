using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8project3
{


        /*********************************************************************************************************
         *Author:Sudha Sugasani
         *Purpose:Create product class whose product price is >500 print values using for loop,
         *         foreach loop,lambda expression,linq query
         **********************************************************************************************************/


        class Product
        {
            public int id;
            public string name;
            public int price;
            public string brand;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Product> p1 = new List<Product>()
                {
                    new Product(){id=1,name="mobile",price=15000,brand="oppo" },
                    new Product(){id=2,name="watch",price=450,brand="sonata" },
                    new Product(){id=3,name="wallet",price=350,brand="lynx" },
                    new Product(){id=4,name="bag",price=1000,brand="sky" },
                    new Product(){id=5,name="chocolate",price=250,brand="dairymilk" }
                };

                //Product names,brands using for loop
                for (int i = 0; i < p1.Count; i++)
                {
                    if (p1[i].price > 500)
                        Console.WriteLine($"Products whose price is >500 using for loop={p1[i].name},{p1[i].brand}");
                }

                //product names,brands using foreach loop
                foreach (var p in p1)
                {
                    if (p.price > 500)
                        Console.WriteLine($"Products whose price is >500 using foreach loop={p.name},{p.brand}");
                }

                //Products names,brands using lambda expression
                p1.Where(p =>p. price > 500).ToList().ForEach(p => Console.WriteLine($"Products  whose price is >500 using lambda expression={p.name},{p.brand}"));

                //Products names,brands using Linq query
                var result = from p in p1
                             where p.price > 500
                             select p.name+","+p.brand;
                result.ToList().ForEach(p => Console.WriteLine($"Products  whose price is >500 using Linq query={p}"));

                Console.ReadLine();
            }
        }
    }




 
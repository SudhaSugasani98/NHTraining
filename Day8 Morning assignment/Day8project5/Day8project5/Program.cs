using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project5
{
   
        /*********************************************************************************************************
         *Author:Sudha Sugasani
         *Purpose:Create Mobile class whose price is >=25000 print values using for loop,
         *         foreach loop,lambda expression,linq query
         **********************************************************************************************************/


        class Mobile
        {
           
            public string name;
            public int price;
            public string warrenty;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Mobile> mob = new List<Mobile>()
                {
                    new Mobile() {name="Oppo",price=20000,warrenty="1year" },
                    new Mobile() {name="Samsung",price=15000,warrenty="6months" },
                    new Mobile() {name="Apple",price=85000,warrenty="1year" },
                    new Mobile() {name="Redmi",price=18000,warrenty="10months" },
                    new Mobile() {name="LG",price=25000,warrenty="1year" }
                 };

                //Mobile names,price using for loop
                for (int i = 0; i < mob.Count; i++)
                {
                    if (mob[i].price >= 25000)
                        Console.WriteLine($"Mobiles whose price is >=25000 using for loop={mob[i].name},{mob[i].price}");
                }

                //Mobile names,price using foreach loop
                foreach (var m in mob)
                {
                    if (m.price >=25000)
                        Console.WriteLine($"Mobiles whose price is >=25000 using foreach loop={m.name},{m.price}");
                }

                //Mobile  names,price using lambda expression
                mob.Where(m => m.price >= 25000).ToList().ForEach(m => Console.WriteLine($"Mobiles whose price is >=25000 using lambda expression={m.name},{m.price}"));

                //Mobile names,price using Linq query
                var result = from m in mob
                             where m.price >=25000
                             select m.name + "," + m.price;
                result.ToList().ForEach(m => Console.WriteLine($"Mobiles whose price is >=25000 using Linq query={m}"));

                Console.ReadLine();
            }
        }
    }

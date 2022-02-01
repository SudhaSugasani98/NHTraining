using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{
    internal class Product
    {
       
            private int productid;
            private string productname;
            private string productdescription;
            private int productprice;
            private int productwarrenty;

            //Creating ReadProduct method  values from user

            public void ReadProduct()
            {
                Console.WriteLine("Enter Productid");
                productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Productname");
                productname = Console.ReadLine();
                Console.WriteLine("Enter Productdescription");
                productdescription = Console.ReadLine();
                Console.WriteLine("Enter Productprice");
                productprice = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Productwarrenty");
                productwarrenty = Convert.ToInt32(Console.ReadLine());

            }

            //Creating PrintProduct to print productdetails
            public void PrintProduct()
            {
                Console.WriteLine($"ID={productid},Name={productname},Description={productdescription},Warrenty={productwarrenty}");
            }
        
        
    }
}

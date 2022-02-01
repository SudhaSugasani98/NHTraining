using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{
    internal class Seller
    {
        private string sellername;
        private string address;
        private int number;
        private string productname;
        private int price;

        

            //Creating ReadSeller method to read values from user

            public void ReadSeller()
            {
                Console.WriteLine("Enter Sellername");
                sellername= Console.ReadLine();
                Console.WriteLine("Enter SellerAddress");
                address = Console.ReadLine();
                Console.WriteLine("Enter Sellernumber");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter productname");
                productname= Console.ReadLine();    
                Console.WriteLine("Enter Productprice");
                price = Convert.ToInt32(Console.ReadLine());

            }

            //Creating PrintSeller method to print Sellerdetails
            public void PrintSeller()
            {
                Console.WriteLine($"Sellernname={sellername},SellerAddress={address},Sellernumber={number},Productname={productname},Productprice={price}");
            }
        }
    }


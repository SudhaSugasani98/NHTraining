using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{
    class Customer
    {
        private int customerid;
        private string customername;
        private string customeraddress;
        private int customernumber;

        //Creating ReadCustomer method to read values from user

        public void ReadCustomer()
        {
            Console.WriteLine("Enter Customerid");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customername");
            customername = Console.ReadLine();
            Console.WriteLine("Enter CustomerAddress");
            customeraddress = Console.ReadLine();
            Console.WriteLine("Enter Customernumber");
            customernumber = Convert.ToInt32(Console.ReadLine());

        }

        //Creating PrintCustomer method to print customerdetails
        public void PrintCustomer()
        {
            Console.WriteLine($"ID={customerid},Name={customername},Address={customeraddress},Number={customernumber}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Product p1= new Product();
            cust.ReadCustomer();
            cust.PrintCustomer();
            Console.ReadLine();
            p1.ReadProduct();
            p1.PrintProduct();
            Console.ReadLine();
            Seller s1= new Seller();
            s1.ReadSeller();
            s1.PrintSeller();
            Console.ReadLine();
            Department d1=new Department();
            d1.ReadDepartment();
            d1.PrintDepartment();
            Console.ReadLine();

        }
    }
}

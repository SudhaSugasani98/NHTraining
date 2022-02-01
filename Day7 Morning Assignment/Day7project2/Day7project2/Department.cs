using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{
    internal class Department
    {
        private int departmentid;
        private string departmentname;
        private int noofemployes;

        


        //Creating ReadDepartment method to read values from user

        public void ReadDepartment()
        {
            Console.WriteLine("Enter Depatment Id");
            departmentid=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter departmentname");
            departmentname = Console.ReadLine();
            Console.WriteLine("Enter No.Of.Employes");
            noofemployes = Convert.ToInt32(Console.ReadLine());
            

        }

        //Creating PrintDepartment method to print Sellerdetails
        public void PrintDepartment()
        {
            Console.WriteLine($"Department Id={departmentid},Department Name={departmentname},No.Of.Employes={noofemployes}");
        }
    }
}

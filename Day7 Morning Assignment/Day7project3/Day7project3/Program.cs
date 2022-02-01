using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project3
{
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
            /*********************************************************************************************************
             * Author:Sudha Sugasani
             * Purpose:Creating Employee Class with 3public variables
             **********************************************************************************************************/
            Employee emp = new Employee() { id = 1, name = "sudha", salary = 5000 };
            Console.WriteLine($"Id={emp.id},Name={emp.name},Salary={emp.salary}");
            Console.ReadLine();
        }
    }
}

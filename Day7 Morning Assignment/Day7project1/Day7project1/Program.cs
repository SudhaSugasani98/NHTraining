
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project1
{
    class Employee
    {
        //Public variables

        private int id;
        private string name;
        private int salary;
        
        //ReadEmploye method to read data from user
        public void ReadEmploye()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name= Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary= Convert.ToInt32(Console.ReadLine());

        }

        //PrintEmploye to print the Employe details
        public void PrintEmploye()
        {
            Console.WriteLine($"Id={id},Name={name},Salary={salary}");
            Console.WriteLine("Id={0},Name={1},Salary={2}",id,name,salary);
            Console.WriteLine("Id=" + id + ",Name=" + name+",Salary=" + salary);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /********************************************************************************************************************************************
             * Author:Sudha Sugasani
             * Purpose:Creating Employee class with three public variables and two methods(ReadEmploye,PrintEmploye),creating an object and calling methods
             *********************************************************************************************************************************************/ 
            Employee emp1 = new Employee();
            emp1.ReadEmploye();
            emp1.PrintEmploye();
            Console.ReadLine();
        }
    }
}

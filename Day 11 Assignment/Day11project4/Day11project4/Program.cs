using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project4
{

    /*******************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Creating a class with properties 
     *         
     ********************************************/
    class Employe
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
       
        internal class Program
        {
            static void Main(string[] args)
            {
                Employe emp = new Employe();
                emp.Id = 505;
                Console.WriteLine($"Employee ID is {emp.Id}");
                emp.Name = "Sudha";
                Console.WriteLine($"Employe Name is {emp.Name}");
                emp.Designation = "Developer";
                Console.WriteLine($"Employee Designation is {emp.Designation}");
                emp.Salary = 30000;
                Console.WriteLine($"Saalry of Employee is {emp.Salary}");
                Console.ReadLine();
            }
        }
    }
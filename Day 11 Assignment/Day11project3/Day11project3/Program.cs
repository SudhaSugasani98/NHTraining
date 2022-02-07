using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project3
{
    /*****************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Creating a claass with properties to access private
     *         Variables.
     *****************************************************************/
    class Employe
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                salary = (designation == "S") ? 30000 : 60000;
                return salary;
            }
        }
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
            
            emp.Designation = "S";
            Console.WriteLine(emp.Salary);
            Console.ReadLine();
        }
    }
}

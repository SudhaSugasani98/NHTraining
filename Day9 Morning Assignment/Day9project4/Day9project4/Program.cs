using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9project4
{

        /**************************************************************************
         * Author:Sudha Sugasani
         * Purpose:Creating an Employee class with variables id,name,salary,company
         *         using constuctors
         * ***********************************************************************/

        class Employee
        {
            public int id;
            public string name;
            public int salary;
            static string company = "NB Healthtech";

        public Employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }
        public Employee(int eid,string ename,int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }


            /// <summary>
            /// This method will read input from user.
            /// </summary>

            public void Readinput()
            {
                Console.WriteLine("Enter  Employee id ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                salary = Convert.ToInt32(Console.ReadLine());
            }

            /// <summary>
            /// This method will print data
            /// </summary>

            public void PrintData()
            {
                Console.WriteLine($"id={id},name={name},salary={salary},company={company}");
            }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee(1,"sudha",5000);
                
                emp.PrintData();
                Console.ReadLine();
            }
        }
    }

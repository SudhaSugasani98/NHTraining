using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9project3
{
    
        /**************************************************************************
         * Author:Sudha Sugasani
         * Purpose:Creating an Employee class with variables id,name,salary,company
         *          write methods to read and print data
         * ***********************************************************************/

        class Employee
        {
            public int id;
            public string name;
            public int salary;
        static string company = "NB Healthtech";


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
                Employee emp = new Employee();
                emp.Readinput();
                emp.PrintData();
            Console.ReadLine();
            }
        }
    }

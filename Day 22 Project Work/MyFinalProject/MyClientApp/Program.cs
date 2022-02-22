using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace MyClientApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("1.Add Employee: ");
                Console.WriteLine("2.Search Employee by ID: ");
                Console.WriteLine("3.Search Employee by Name: ");
                Console.WriteLine("4.Display all Employees: ");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeByID();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployess();
                        break;
                    default:
                        Console.WriteLine("Invalid Option ");
                        break;

                }
                Console.WriteLine("Do you want to continue (y/n) ");
                choice = Console.ReadLine();

            }
            
            while (choice.Equals("y")) ;
        }
            /// <summary>
            /// This method will take the input from user and store it in the file using BLL
            /// </summary>
            public static void AddEmployee()
            {
                int id;
                string name;
                int salary;
                int age;
                Console.WriteLine("Enter ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                //Calling method in BLL
                var result = EmployeeBLL.AddEmployee(id, name, salary, age);
                if (result)
                {
                    Console.WriteLine("Employee Details saved successfully ");

                }
                else
                {
                    Console.WriteLine("Some error occurred ");
                }
                
            }
            /// <summary>
            /// This Method will print the EmployeeId if it is found using BLl
            /// </summary>
            public static void SearchEmployeeByID()
            {
                int id;
                Console.WriteLine("Enter id: ");
                id = Convert.ToInt32(Console.ReadLine());
                var result = EmployeeBLL.GetEmployeesByID(id);
                if(result.Count==0)
                {
                    Console.WriteLine("No records found with this id ");
                }
                else
                {
                    result.ForEach(p => Console.WriteLine(p));
                }
            }
            /// <summary>
            /// This method will check the employeename if the given name is contained in data it'll print names using BLL
            /// </summary>
            public static void SearchEmployeeByName()
            {
                string name;
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                var result = EmployeeBLL.GetEmployeesByName(name);
                
                if(result.Count==0)
                {
                    Console.WriteLine("No records are matching with this name");
                }
                else
                {
                    result.ForEach(n => Console.WriteLine(n));
                    
                }
            }
            /// <summary>
            /// This method will print all Employee details using BLl
            /// </summary>
            public static void DisplayAllEmployess()
            {
                 var result = EmployeeBLL.GetAllEmployees();
                 result.ToList().ForEach(e => Console.WriteLine(e));
               // Console.WriteLine(result);
            }
    }
}

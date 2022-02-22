using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        /// <summary>
        /// This method will return the entered employee details using DAL if all the validations are passed
        /// </summary>
        /// <param name="empID">int</param>
        /// <param name="empName">String</param>
        /// <param name="empSalary">int</param>
        /// <param name="empAge">int</param>
        /// <returns>result(var)</returns>
        public static bool AddEmployee(int empID,string empName,int empSalary,int empAge)
        {
            //string filepath = "C:\\NH\\Files Using C#\\Employees.txt";
                
             string [] employee = File.ReadAllLines("C:\\NH\\Files Using C#\\Employees.txt");
            
            foreach(var e in employee)
            {
                string id = Convert.ToString(empID);
                
                 if(employee.Equals(id))
                 {
                      Console.WriteLine("Employee id must not be same as existing employee id");
                       return false;
                 }
               
                
            }
            
            if(empID <= 0&& ((empName.Length) <=3) && empSalary <= 10000 && (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee id must be Positive number");
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Salary must be more than 10,000");
                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;

            }
            else if(empID <= 0 && ((empName.Length) < 3) && empSalary <= 10000)
            {
                Console.WriteLine("Employee id must be Positive number");
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Salary must be more than 10,000");
                return false;
            }
            else if(empID <= 0 && ((empName.Length) < 3) && (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee id must be Positive number");
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;
            }
            else if(((empName.Length) < 3) && empSalary <= 10000 && (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Salary must be more than 10,000");
                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;
            }
            else if(empID <= 0 && ((empName.Length) < 3))
            {
                Console.WriteLine("Employee id must be Positive number");
                Console.WriteLine("Employee Name must be atleast 3 characters");
                return false;
            }
            else if(empID <= 0 && empSalary <= 10000)
            {
                Console.WriteLine("Employee id must be Positive number");
                Console.WriteLine("Employee Salary must be more than 10,000");
                return false;

            }
            else if(empID <= 0 && (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee id must be Positive number");

                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;
            }
            else if(((empName.Length) < 3) && empSalary < 10000)
            {
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Salary must be more than 10,000");
                return false;
            }
            else if(((empName.Length) < 3)&& (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee Name must be atleast 3 characters");
                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;

            }
            else if(empSalary <= 10000 && (empAge < 18 || empAge > 58))
            {
                Console.WriteLine("Employee Salary must be more than 10,000");

                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;
            }


            else if(empID<=0)
            {
                Console.WriteLine("Employee id must be Positive number");
               return false;
            }
            else if(empName.Length<=3)
            {
                Console.WriteLine("Employee Name must be atleast 3 characters");
                return false;
            }
            else if(empSalary<=10000)
            {
                Console.WriteLine("Employee Salary must be more than 10,000");
                return false;
            }
            else if(empAge<18||empAge>58)
            {
                Console.WriteLine("Employee Age must be between 18 and 58");
                return false;
            }
            
                var result = EmployeeDAL.AddEmployee(empID, empName, empSalary, empAge);
                return result;
            
            
        }
        /// <summary>
        /// This method will return the id  using DAL if the entered id is matching with the existing data 
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>result(var)</returns>
        public static List<string> GetEmployeesByID(int id)
        {
            var result = EmployeeDAL.GetEmployeesByID(id);
            return result;
        }
        /// <summary>
        /// This method will return name using DAl if the entered name is contained in data
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>result(var)</returns>
        public static List<string> GetEmployeesByName(string name)
        {
            var result = EmployeeDAL.GetEmployeesByName(name);
            return result;
        }
        /// <summary>
        /// This method will return all the employee details using DAL
        /// </summary>
        /// <returns>result(var)</returns>
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}

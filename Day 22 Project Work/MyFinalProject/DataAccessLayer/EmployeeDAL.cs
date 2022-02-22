using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// This method will return the entered employee details in file
    /// </summary>
    public static class EmployeeDAL
    {
        public static string filePath = "C:\\NH\\Files Using C#\\Employees.txt";
        public static bool AddEmployee(int empID,String empName,int empSalary,int empAge)
        {
            try
            {
                string textcontent = string.Concat(empID, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filePath, textcontent + Environment.NewLine);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// This method will check the entered employee id and the existing employee id,if both are true it will return the matching id employeedetails 
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>employeeFound(employee details if both id's are matching)</returns>
        public static List<string> GetEmployeesByID(int id)
        {
            var AllEmployees = File.ReadAllLines(filePath);
            bool isfound = false;
            List<string> employeeFound = new List<string>();
            foreach(string employee in AllEmployees)
            {
                var empDetails = employee.Split(',');
                if(Convert.ToInt32(empDetails[0])==id)
                {
                    isfound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method will check the entered employeename is present in existing employee details,if both are true it will return the name which contains in the employeedetails
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>employeeFound(name that is contained in file)</returns>
        public static List<string> GetEmployeesByName(string name)
        {
            var AllEmployees = File.ReadAllLines(filePath);

            List<string> employeeFound = new List<string>();
            foreach (string employee in AllEmployees)
            {
                var empDetails = employee.Split(',');
                if ((empDetails[1].Contains(name)))
                {
                    employeeFound.Add(employee);

                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method will return all employeedetails 
        /// </summary>
        /// <returns>allEmployees(data of all employees)</returns>
        public static string[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;
        }
    }
}

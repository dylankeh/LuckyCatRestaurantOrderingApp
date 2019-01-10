using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyCatWinFormsApp.Models
{
    /// <summary>
    /// This class will store employee information from database 
    /// , which used to pass information between different windows
    /// 
    /// Created by: Qing Ge
    /// </summary>
    public class Employee
    {
        public Employee(string employeeID, string employeeName, string permission)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Permission = permission;
        }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Permission { get; set; }
    }
}

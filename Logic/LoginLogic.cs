using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginLogic
    {
        EmployeeDao employeeDao;
        List<Employee> employees;
        Employee employee;

        public LoginLogic()
        {
            employeeDao = new EmployeeDao();
            employees = employeeDao.GetEmployees();
        }

        public bool CheckForAccountInDatabase(string username, string password)
        {
            bool isAccountInDatabase = false;

            foreach (Employee employee in employees)
            {
                if (employee.Username == username && employee.Password == password)
                {
                    this.employee = employee;
                    isAccountInDatabase = true;
                    break;
                }
            }
            return isAccountInDatabase;
        }
        public Employee GetEmployee()
        {
            return employee;
        }
    }
}

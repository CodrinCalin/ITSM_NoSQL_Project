using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Logic
{
    public class LoginLogic
    {
        EmployeeDao employeeDao;
        Employee employee;

        public LoginLogic()
        {
            employeeDao = new EmployeeDao();
        }

        public bool CheckForAccountInDatabase(string username, string passwordInput)
        {
            bool isAccountInDatabase = false;

           Employee employee = employeeDao.GetEmployeeByUsername(username);
           if (employee != null)
           {
                if (BCrypt.Net.BCrypt.Verify(passwordInput, employee.Password))
                {
                    this.employee = employee;
                    isAccountInDatabase = true;
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

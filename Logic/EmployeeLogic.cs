using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Logic
{
    public class EmployeeLogic
    {
        private EmployeeDao employeeDao;

        public EmployeeLogic()
        {
            employeeDao = new EmployeeDao();
        }

        public Employee GetEmployeeById(ObjectId employeeId)
        {
            return employeeDao.GetEmployeeById(employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            employeeDao.AddEmployee(employee);
        }

        public List<Employee> GetEmployees()
        {
            return employeeDao.GetEmployees();
        }

        public List<Employee> GetEmployeeByEmail(string email)
        {
            return employeeDao.GetEmployeesByEmail(email);
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return employeeDao.GetEmployeeByUsername(username);
        }
    }
}

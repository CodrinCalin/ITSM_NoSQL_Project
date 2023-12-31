﻿using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class EmployeeDao
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Employee> collection;

        public EmployeeDao()
        {
            try
            {
                client = new MongoClient("mongodb+srv://706431:user123@cluster0.bvkka8o.mongodb.net/");
                db = client.GetDatabase("NoSQL_ProjectDatabase");
                collection = db.GetCollection<Employee>("Employees");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem while connecting to the database.");
                throw ex;
               
            }
        }

        public List<Employee> GetEmployees()   // all employees
        {
            var filter = new BsonDocument();

            List<Employee> employees = collection.Find(filter).ToList();

            return employees;
        }

        public Employee GetEmployeeById(ObjectId employeeId)
        {
            var filter = Builders<Employee>.Filter.Eq(x => x.Id, employeeId);
            return collection.Find(filter).FirstOrDefault();
        }

        public void AddEmployee(Employee employee)
        {
            collection.InsertOne(employee);
        }
        public Employee GetEmployeeByUsername(string username)
        {
            var filter = Builders<Employee>.Filter.Eq(x => x.Username, username);
            return collection.Find(filter).FirstOrDefault();
        }

        public List<Employee> GetEmployeesByEmail(string email)
        {
            var filter = Builders<Employee>.Filter.Eq(x => x.Email, email);
            return collection.Find(filter).ToList();
        }
    }
}

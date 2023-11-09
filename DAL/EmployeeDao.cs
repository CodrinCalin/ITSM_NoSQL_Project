using Model;
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
            client = new MongoClient("mongodb+srv://706431:user123@cluster0.bvkka8o.mongodb.net/");
            db = client.GetDatabase("NoSQL_ProjectDatabase");
            collection = db.GetCollection<Employee>("Employees");
        }

        public List<Employee> GetEmployees()
        {
            // Create a filter to match all documents (if you want to retrieve all employees)
            var filter = new BsonDocument();

            List<Employee> employees = collection.Find(filter).ToList();

            return employees;
        }

        public Employee GetEmployeeById(ObjectId employeeId)
        {
            var filter = Builders<Employee>.Filter.Eq(x => x.Id, employeeId);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}

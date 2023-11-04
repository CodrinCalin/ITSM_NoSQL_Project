using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Employee
    {
        public ObjectId Id { get; set; } // MongoDB ObjectId
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsSuperDesk { get; set; }
        public string LocationBranch { get; set; }
        public string Password { get; set; }

    }
}

using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public ObjectId Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public string SubjectOfIncident { get; set; }
        public string TypeOfIncident { get; set; }
        public string UserID { get; set; }
        public TicketPriority Priority { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public ObjectId EmployeeID { get; set; }
    }
}

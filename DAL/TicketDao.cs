using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DAL
{
    public class TicketDao
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Ticket> collection;

        public TicketDao()
        {
            try
            {
                client = new MongoClient("mongodb+srv://706431:user123@cluster0.bvkka8o.mongodb.net/");
                db = client.GetDatabase("NoSQL_ProjectDatabase");
                collection = db.GetCollection<Ticket>("Tickets");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem while connecting to the database.");
                throw ex;
            }
        }

        public List<Ticket> GetTickets()
        {
            var filter = new BsonDocument();
            List<Ticket> tickets = collection.Find(filter).ToList();
            return tickets;
        }

        public List<Ticket> GetTicketsBaseOnEmployeeId(Employee employee)
        {
            var filter = Builders<Ticket>.Filter.Eq("EmployeeID", employee.Id);
            List<Ticket> tickets = collection.Find(filter).ToList();
            return tickets;
        }

        public void CreateTicket(Ticket ticket)
        {
            collection.InsertOne(ticket);
        }

        public void UpdateTicket(ObjectId id, Ticket updatedTicket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);

            var update = Builders<Ticket>.Update
                .Set(t => t.SubjectOfIncident, updatedTicket.SubjectOfIncident)
                .Set(t => t.Description, updatedTicket.Description)
                .Set(t => t.TypeOfIncident, updatedTicket.TypeOfIncident)
                .Set(t => t.UserID, updatedTicket.UserID)
                .Set(t => t.Priority, updatedTicket.Priority)
                .Set(t => t.Status, updatedTicket.Status)
                .Set(t => t.Deadline, updatedTicket.Deadline);

            collection.UpdateOne(filter, update);
        }


        public void DeleteTicket(ObjectId id) 
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);
            collection.DeleteOne(filter);
        }

        public void CloseTicket(ObjectId id)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);
            var update = Builders<Ticket>.Update.Set(t => t.Status, TicketStatus.Closed);

            collection.UpdateOne(filter, update);
        }

        public void EscaladeTicket(ObjectId id)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);
            var update = Builders<Ticket>.Update.Set(t => t.Status, TicketStatus.Escalated);

            collection.UpdateOne(filter, update);
        }

        public List<Ticket> GetTicketsByPriority(TicketPriority priority)
        {
            var filter = Builders<Ticket>.Filter.Eq("Priority", priority.ToString());
            List<Ticket> tickets = collection.Find(filter).ToList();
            return tickets;
        }

        public List<Ticket> GetTicketsBySortOrder(MySortOrder sortOrder)
        {
            var sortField = Builders<Ticket>.Sort.Ascending("Priority");

            if (sortOrder == MySortOrder.Descending)
            {
                sortField = Builders<Ticket>.Sort.Descending("Priority");
            }
            List<Ticket> tickets = collection.Find(new BsonDocument()).Sort(sortField).ToList();
            return tickets;
        }

        public void ChangeTicketEmployeeId(ObjectId ticketId, ObjectId newEmployeeId)
        {
            var filter = Builders<Ticket>.Filter.Eq(x => x.Id, ticketId);
            var update = Builders<Ticket>.Update.Set(x => x.EmployeeID, newEmployeeId);

            collection.UpdateOne(filter, update);
        }
    }
}

using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDao
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Ticket> collection;

        public TicketDao()
        {
            client = new MongoClient("mongodb+srv://706431:user123@cluster0.bvkka8o.mongodb.net/");
            db = client.GetDatabase("NoSQL_ProjectDatabase");
            collection = db.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetTickets()
        {
            var filter = new BsonDocument();
            List<Ticket> tickets = collection.Find(filter).ToList();
            return tickets;
        }

        public void CreateTicket(Ticket ticket)
        {
            collection.InsertOne(ticket);
        }

        public Ticket ReadTicket(ObjectId id)
        {
            // Find the ticket by its unique identifier
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);
            var ticket = collection.Find(filter).FirstOrDefault();

            return ticket;
        }

        public void UpdateTicket(ObjectId id, Ticket updatedTicket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);

            var update = Builders<Ticket>.Update
                .Set(t => t.SubjectOfIncident, updatedTicket.SubjectOfIncident)
                .Set(t => t.Description, updatedTicket.Description);

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
    }
}

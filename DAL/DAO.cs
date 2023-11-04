using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        private IMongoCollection<Ticket> collection; // Declare the collection object

        public DAO()
        {
            client = new MongoClient("mongodb+srv://706431:user123@cluster0.bvkka8o.mongodb.net/");
            var database = client.GetDatabase("NoSQL_ProjectDatabase");
            collection = database.GetCollection<Ticket>("Tickets"); // Instantiate the collection object
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();

            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }

        public void CreateTicket(Ticket ticket)
        {
            collection.InsertOne(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return collection.Find(new BsonDocument()).ToList();
        }

        public void UpdateTicket(ObjectId id, Ticket updatedTicket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, id);

            // Use the correct properties for update, e.g., SubjectOfIncident and Description
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
    }
}

using DAL;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DemoApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            // Instantiate the DAO class
            var dao = new DAO();

            // Test CRUD methods
            var newTicket = new Ticket
            {
                DateAndTime = DateTime.Now,
                SubjectOfIncident = "Test Incident",
                TypeOfIncident = "Test Type",
                UserID = "testuser",
                Priority = "High",
                Deadline = DateTime.Now.AddDays(7),
                Description = "This is a test incident.",
                EmployeeID = ObjectId.GenerateNewId()
            };

            // Create (Insert) a Ticket
            dao.CreateTicket(newTicket);
            Console.WriteLine("Ticket created with Id: " + newTicket.Id);

            // Read (Retrieve) Tickets
            var tickets = dao.GetTickets();
            Console.WriteLine("Tickets:");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Id: {ticket.Id}, Subject: {ticket.SubjectOfIncident}");
            }

            // Update a Ticket
            if (tickets.Count > 0)
            {
                var firstTicketId = tickets[0].Id;
                var updatedTicket = new Ticket
                {
                    Id = firstTicketId,
                    SubjectOfIncident = "Updated Incident",
                    Description = "This is the updated incident."
                };
                dao.UpdateTicket(firstTicketId, updatedTicket);
                Console.WriteLine("Ticket updated.");
            }

            // Delete a Ticket
            if (tickets.Count > 1)
            {
                var ticketToDelete = tickets[1];
                dao.DeleteTicket(ticketToDelete.Id);
                Console.WriteLine("Ticket deleted.");
            }

            Console.ReadLine();
        }
    }
}

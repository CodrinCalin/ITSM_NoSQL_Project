using DAL;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketLogic
    {
        private TicketDao ticketDao;
        private List<Ticket> tickets;

        public TicketLogic(Employee employee)
        {
            ticketDao = new TicketDao();
            tickets = ticketDao.GetTicketsBaseOnEmployeeId(employee);
        }
        public TicketLogic() 
        {
            ticketDao = new TicketDao();
            tickets = ticketDao.GetTickets();
        }
        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public void DeleteTicket(ObjectId ticketID)
        {
            ticketDao.DeleteTicket(ticketID);
        }

        public void CloseTicket(ObjectId ticketID)
        {
            ticketDao.CloseTicket(ticketID);
        }

        public void UpdateTicket(ObjectId ticketID, Ticket updatedTicket)
        {
            ticketDao.UpdateTicket(ticketID, updatedTicket);
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketDao.CreateTicket(ticket);
        }
      
    }
}

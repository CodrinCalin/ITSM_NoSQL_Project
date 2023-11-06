using DAL;
using Model;
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


       
    }
}
